using eShop.Core.Data;
using FluentValidation.Results;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IAmostraService
    {
        Task<ValidationResult> Adicionar(Amostra amostra);
    }

    public interface IAmostraRepository : IRepository<Amostra>
    {
        void Adicionar(Amostra amostra);
        Task<IEnumerable<Amostra>> Amostras();
        Task<Amostra> ObterAmostra(Guid id);
    }
}
