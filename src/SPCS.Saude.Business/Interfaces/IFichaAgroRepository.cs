using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Core.Data;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IFichaAgroRepository : IRepository<FichaAgro>
    {
        void Adicionar(FichaAgro fichaAgro);
        void Atualizar(FichaAgro fichaAgro);

        Task<FichaAgro> ObterPorId(Guid id);
        Task<IEnumerable<FichaAgro>> ListarAsync();
    }
}
