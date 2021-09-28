using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IAgrotoxicoRepository : IRepository<Agrotoxico>
    {
        void Adicionar(Agrotoxico agrotoxico);
        void Atualizar(Agrotoxico agrotoxico);

        Task<Agrotoxico> ObterPorId(Guid id);
        Task<IEnumerable<Agrotoxico>> ObterTodos();
    }
}
