using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class MedicoService : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task<ValidationResult> Adicionar(Medico medico)
        {
            if (!medico.IsValid())
                return medico.ValidationResult;

            _medicoRepository.Adicionar(medico);
            return await PersistirDados(_medicoRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Medico medico)
        {
            throw new NotImplementedException();
        }
    }
}
