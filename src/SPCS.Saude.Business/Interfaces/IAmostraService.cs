using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IAmostraService
    {
        Task<ValidationResult> Adicionar(Amostra amostra);
    }
}
