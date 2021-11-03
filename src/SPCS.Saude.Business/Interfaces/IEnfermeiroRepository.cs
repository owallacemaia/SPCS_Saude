using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IEnfermeiroRepository : IRepository<Enfermeiro>
    {
        void Adicionar(Enfermeiro enfermeiro);
        void Atualizar(Enfermeiro enfermeiro);
        Task<Enfermeiro> EnfermeiroFiltro(string cpf = null, string corem = null);
        Task<Enfermeiro> ObterPorId(Guid id);
        Task<IEnumerable<Enfermeiro>> ObterTodos();
    }
}
