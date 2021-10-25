using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Identidade;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Services
{
    public class AccessManager
    {
        public readonly SignInManager<IdentityUser> SignInManager;
        public readonly UserManager<IdentityUser> UserManager;
        private SigningConfigurations _signingConfigurations;
        private TokenConfigurations _tokenConfigurations;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioService _usuarioService;

        public AccessManager(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            SigningConfigurations signingConfigurations,
            TokenConfigurations tokenConfigurations,
            IUsuarioRepository usuarioRepository,
            IUsuarioService usuarioService)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _signingConfigurations = signingConfigurations;
            _tokenConfigurations = tokenConfigurations;
            _usuarioRepository = usuarioRepository;
            _usuarioService = usuarioService;
        }

        public async Task<UsuarioLoginResponseApiModel> GerarToken(string email)
        {
            var user = await UserManager.FindByEmailAsync(email);
            var claims = await UserManager.GetClaimsAsync(user);

            var identityClaims = await ObterClaimsUsuario(claims, user);
            var token = CodificarToken(identityClaims);

            return await ObterRespostaToken(user, token, claims);
        }

        private async Task<ClaimsIdentity> ObterClaimsUsuario(ICollection<Claim> claims, IdentityUser user)
        {
            var userRoles = await UserManager.GetRolesAsync(user);

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim("role", userRole));
            }

            var identityClaims = new ClaimsIdentity();

            identityClaims.AddClaims(claims);

            return identityClaims;
        }

        private string CodificarToken(ClaimsIdentity claims)
        {
            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao +
            TimeSpan.FromMinutes(_tokenConfigurations.Minutes);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = claims,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });

            var token = handler.WriteToken(securityToken);

            return token;
        }

        private async Task<UsuarioLoginResponseApiModel> ObterRespostaToken(IdentityUser credenciais, string token, ICollection<Claim> claims)
        {
            var resposta = new UsuarioLoginResponseApiModel
            {
                AccessToken = token,
                ExpiresIn = _tokenConfigurations.Minutes,
                RefreshToken = Guid.NewGuid().ToString().Replace("-", String.Empty),
                UsuarioToken = new UsuarioToken
                {
                    Id = credenciais.Id,
                    Email = credenciais.Email,
                    Claims = claims.Select(c => new UsuarioClaim { Type = c.Type, Value = c.Value })
                }
            };

            await GravarToken(resposta);

            return resposta;
        }

        private async Task GravarToken(UsuarioLoginResponseApiModel usuario)
        {
            var finalExpiration = DateTime.UtcNow + TimeSpan.FromDays(_tokenConfigurations.FinalExpiration);
            var refreshTokenData = new RefreshTokenData(usuario.RefreshToken, usuario.UsuarioToken.Email, finalExpiration, DateTime.UtcNow);

            await _usuarioService.GravarToken(refreshTokenData);
        }

        public async Task<RefreshTokenData> ObterRefreshToken(string refreshToken)
        {
            return await _usuarioRepository.ObterTokenUsuario(refreshToken);
        }

        public async Task RemoverToken(RefreshTokenData refreshToken)
        {
            _usuarioRepository.RemoverTokenUsuario(refreshToken);
        }
    }
}
