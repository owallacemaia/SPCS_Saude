using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IMedicoRepository : IRepository<Medico>
    {
        void Adicionar(Medico usuario);
        Task<Medico> ObterPorId(Guid id);
        Task<IEnumerable<Medico>> ObterTodos();
    }
}
