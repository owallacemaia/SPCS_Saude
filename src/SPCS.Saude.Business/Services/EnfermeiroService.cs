using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class EnfermeiroService : BaseService, IEnfermeiroService
    {
        private readonly IEnfermeiroRepository _enfermeiroRepository;

        public EnfermeiroService(IEnfermeiroRepository enfermeiroRepository)
        {
            _enfermeiroRepository = enfermeiroRepository;
        }

        public async Task<ValidationResult> Adicionar(Enfermeiro enfermeiro)
        {
            if (!enfermeiro.IsValid())
                return enfermeiro.ValidationResult;

            _enfermeiroRepository.Adicionar(enfermeiro);
            return await PersistirDados(_enfermeiroRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Enfermeiro enfermeiro)
        {
            throw new NotImplementedException();
        }
    }
}
