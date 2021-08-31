using FluentValidation.Results;
using NetDevPack.Data;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Services
{
    public abstract class BaseService
    {
        protected ValidationResult ValidationResult;

        protected BaseService()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AdicionarErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
