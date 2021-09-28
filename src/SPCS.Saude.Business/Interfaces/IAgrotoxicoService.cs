using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IAgrotoxicoService
    {
        Task<ValidationResult> Adicionar(Agrotoxico agrotoxico);
        Task<ValidationResult> Atualizar(Agrotoxico agrotoxico);
    }
}
