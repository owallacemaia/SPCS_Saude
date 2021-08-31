using NetDevPack.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Remover(Guid id);
        Task<Usuario> ObterPorCpf(string cpf);
        Task<Usuario> ObterPorId(Guid id);
        Task<Usuario> ObterPorEmail(string email);
        void GravarToken(RefreshTokenData refreshToken);
        Task<RefreshTokenData> ObterTokenUsuario(string email);
        Task<IEnumerable<Usuario>> ObterPorTipo(Guid tipoId);
        Task<IEnumerable<Usuario>> ObterTodos();
    }
}
