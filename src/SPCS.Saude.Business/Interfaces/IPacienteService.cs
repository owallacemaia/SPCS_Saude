using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IPacienteService
    {
        Task<ValidationResult> Adicionar(Paciente paciente);
        Task<ValidationResult> Atualizar(Paciente paciente);
    }
}
