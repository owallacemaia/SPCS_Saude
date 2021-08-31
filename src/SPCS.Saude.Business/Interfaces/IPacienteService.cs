using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IPacienteService
    {
        Task<ValidationResult> Adicionar(Paciente paciente);
        Task<ValidationResult> Atualizar(Paciente paciente);
    }

    public interface IMedicoService
    {
        Task<ValidationResult> Adicionar(Medico medico);
        Task<ValidationResult> Atualizar(Medico medico);
    }

    public interface IEnfermeiroService
    {
        Task<ValidationResult> Adicionar(Enfermeiro enfermeiro);
        Task<ValidationResult> Atualizar(Enfermeiro enfermeiro);
    }
}
