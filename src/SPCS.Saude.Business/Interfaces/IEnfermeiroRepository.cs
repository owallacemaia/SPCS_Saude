using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IEnfermeiroRepository : IRepository<Enfermeiro>
    {
        void Adicionar(Enfermeiro enfermeiro);
        Task<Enfermeiro> ObterInformacoesPorUsuarioId(Guid id);
    }
}
