using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<ValidationResult> Adicionar(Usuario usuario)
        {
            if (!usuario.EhValido())
                return usuario.ValidationResult;

            var usuarioExistente = await _usuarioRepository.ObterPorCpf(usuario.Cpf);

            if (usuarioExistente != null)
            {
                AdicionarErro("Já existe um usuário cadastrado com o CPF informado");
                return ValidationResult;
            }

            _usuarioRepository.Adicionar(usuario);

            return await PersistirDados(_usuarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Atualizar(Usuario usuario)
        {
            if (!usuario.EhValido())
                return usuario.ValidationResult;

            _usuarioRepository.Atualizar(usuario);

            return await PersistirDados(_usuarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> GravarToken(RefreshTokenData refreshToken)
        {
            if(refreshToken.RefreshToken == null)
            {
                AdicionarErro("O token está vazio");
            }

            _usuarioRepository.GravarToken(refreshToken);

            return await PersistirDados(_usuarioRepository.UnitOfWork);
        }

        public void Remover(Guid usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
