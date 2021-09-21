using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IFichaService
    {
        Task<ValidationResult> Adicionar(Ficha ficha);
        Task<ValidationResult> Atualizar(Ficha ficha);
    }
}
