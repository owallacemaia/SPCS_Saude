using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class PacienteService : BaseService, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public async Task<ValidationResult> Adicionar(Paciente paciente)
        {
            if (!paciente.IsValid())
                return paciente.ValidationResult;

            _pacienteRepository.Adicionar(paciente);
            return await PersistirDados(_pacienteRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
