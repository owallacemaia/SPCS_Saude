using FluentValidation.Results;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public class FichaService : BaseService, IFichaService
    {
        private readonly IFichaRepository _fichaRepository;

        public FichaService(IFichaRepository fichaRepository)
        {
            _fichaRepository = fichaRepository;
        }

        public async Task<ValidationResult> Adicionar(Ficha ficha)
        {
            _fichaRepository.Adicionar(ficha);

            return await PersistirDados(_fichaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Atualizar(Ficha ficha)
        {
            throw new NotImplementedException();
        }
    }
}
