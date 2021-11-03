using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IFichaRepository : IRepository<Ficha>
    {
        void Adicionar(Ficha ficha);
        void Atualizar(Ficha ficha);

        Task<Ficha> ObterPorId(Guid id);
        Task<IEnumerable<Ficha>> ListarAsync();
    }
}
