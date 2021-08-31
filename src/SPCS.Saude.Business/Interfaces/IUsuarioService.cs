using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IUsuarioService
    {
        Task<ValidationResult> Adicionar(Usuario usuario);
        Task<ValidationResult> Atualizar(Usuario usuario);
        Task<ValidationResult> GravarToken(RefreshTokenData refreshToken);
        void Remover(Guid usuarioId);
    }
}
