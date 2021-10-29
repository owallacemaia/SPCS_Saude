using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.API.Services;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Identidade;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/auth")]
    public class AuthController : MainController
    {
        private readonly AccessManager _accessManager;
        private readonly IUsuarioService _usuarioService;

        public AuthController(AccessManager accessManager, IUsuarioService usuarioService)
        {
            _accessManager = accessManager;
            _usuarioService = usuarioService;
        }

        [ClaimsAuthorize("Administrador", "Total")]
        [HttpPost("nova-conta")]
        public async Task<IActionResult> Registrar(CadastrarAdminRequestApiModel usuarioRegistro)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            var user = new IdentityUser
            {
                UserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                EmailConfirmed = true
            };

            var result = await _accessManager.UserManager.CreateAsync(user, usuarioRegistro.Senha);

            if (result.Succeeded)
            {
                var novoUsuario = new Usuario(Guid.Parse(user.Id), usuarioRegistro.Nome, usuarioRegistro.Email, usuarioRegistro.Cpf, usuarioRegistro.TipoUsuarioId);
                var registrarUsuario = await _usuarioService.Adicionar(novoUsuario);

                if (!registrarUsuario.IsValid)
                {
                    await _accessManager.UserManager.DeleteAsync(user);
                    return CustomResponse(registrarUsuario);
                }

                await _accessManager.UserManager.AddClaimAsync(user, new Claim("Administrador", "Total"));

                return CustomResponse(await _accessManager.GerarToken(user.Email));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

        [HttpPost("autenticar")]
        public async Task<ActionResult<UsuarioLoginResponseApiModel>> Login(UsuarioLoginRequestApiModel usuarioLogin, [FromServices] AccessManager accessManager)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            var result = await _accessManager.SignInManager.PasswordSignInAsync(usuarioLogin.Email, usuarioLogin.Senha,
                false, true);

            if (result.Succeeded)
            {
                return CustomResponse(await _accessManager.GerarToken(usuarioLogin.Email));
            }

            if (result.IsLockedOut)
            {
                AdicionarErroProcessamento("Usuário temporariamente bloqueado por tentativas inválidas");
                return CustomResponse();
            }

            AdicionarErroProcessamento("Usuário ou Senha incorretos");
            return CustomResponse();
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult> RefreshToken([FromBody] string refreshToken)
        {
            if (string.IsNullOrEmpty(refreshToken))
            {
                AdicionarErroProcessamento("Refresh Token inválido");
                return CustomResponse();
            }

            var token = await _accessManager.ObterRefreshToken(refreshToken);

            if (token is null || token.Expires <= DateTime.Now)
            {
                AdicionarErroProcessamento("Refresh Token expirado");
                return CustomResponse();
            }

            await _accessManager.RemoverToken(token);

            return CustomResponse(await _accessManager.GerarToken(token.Email));
        }
    }
}
