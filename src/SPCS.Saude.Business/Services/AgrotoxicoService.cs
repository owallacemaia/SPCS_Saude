using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class AgrotoxicoService : BaseService, IAgrotoxicoService
    {
        private readonly IAgrotoxicoRepository _agrotoxicoRepository;

        public AgrotoxicoService(IAgrotoxicoRepository agrotoxicoRepository)
        {
            _agrotoxicoRepository = agrotoxicoRepository;
        }

        public async Task<ValidationResult> Adicionar(Agrotoxico agrotoxico)
        {
            if (!agrotoxico.IsValid())
                return agrotoxico.ValidationResult;

            _agrotoxicoRepository.Adicionar(agrotoxico);

            return await PersistirDados(_agrotoxicoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Atualizar(Agrotoxico agrotoxico)
        {
            if (!agrotoxico.IsValid())
                return agrotoxico.ValidationResult;

            _agrotoxicoRepository.Atualizar(agrotoxico);

            return await PersistirDados(_agrotoxicoRepository.UnitOfWork);
        }
    }
}
