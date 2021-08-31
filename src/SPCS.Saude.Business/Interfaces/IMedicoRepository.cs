using NetDevPack.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IMedicoRepository : IRepository<Medico>
    {
        void Adicionar(Medico usuario);
        Task<Medico> ObterInformacoesPorUsuarioId(Guid id);
    }
}
