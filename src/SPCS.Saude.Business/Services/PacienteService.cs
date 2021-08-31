using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _pacienteRepository.Adicionar(paciente);
            return await PersistirDados(_pacienteRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }

    public class MedicoService : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task<ValidationResult> Adicionar(Medico medico)
        {
            _medicoRepository.Adicionar(medico);
            return await PersistirDados(_medicoRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Medico medico)
        {
            throw new NotImplementedException();
        }
    }

    public class EnfermeiroService : BaseService, IEnfermeiroService
    {
        private readonly IEnfermeiroRepository _enfermeiroRepository;

        public EnfermeiroService(IEnfermeiroRepository enfermeiroRepository)
        {
            _enfermeiroRepository = enfermeiroRepository;
        }

        public async Task<ValidationResult> Adicionar(Enfermeiro enfermeiro)
        {
            _enfermeiroRepository.Adicionar(enfermeiro);
            return await PersistirDados(_enfermeiroRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Enfermeiro enfermeiro)
        {
            throw new NotImplementedException();
        }
    }
}
