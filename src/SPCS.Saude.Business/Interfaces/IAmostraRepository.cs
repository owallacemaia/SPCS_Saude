using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IAmostraRepository : IRepository<Amostra>
    {
        void Adicionar(Amostra amostra);
        Task<IEnumerable<Amostra>> ListarAsync();
        Task<Amostra> ObterPorId(Guid id);
    }
}
