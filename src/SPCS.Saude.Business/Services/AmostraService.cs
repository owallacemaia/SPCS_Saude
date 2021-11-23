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
    public class AmostraService : BaseService, IAmostraService
    {
        private IAmostraRepository _amostraRepository;

        public AmostraService(IAmostraRepository amostraRepository)
        {
            _amostraRepository = amostraRepository;
        }

        public async Task<ValidationResult> Adicionar(Amostra amostra)
        {
            if (!amostra.IsValid())
                return amostra.ValidationResult;

            _amostraRepository.Adicionar(amostra);

            return await PersistirDados(_amostraRepository.UnitOfWork);
        }
    }
}
