using eShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Infra.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Infra.Repository
{
    class FichaAgroRepository: IFichaAgroRepository
    {
        private readonly PrincipalDbContext _context;

        public FichaAgroRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(FichaAgro fichaAgro)
        {
            _context.FichasAgro.Add(fichaAgro);
        }

        public void Atualizar(FichaAgro fichaAgro)
        {
            _context.FichasAgro.Update(fichaAgro);
        }

        public async Task<FichaAgro> ObterPorId(Guid id)
        {
            return await _context.FichasAgro.AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<FichaAgro>> ListarAsync()
        {
            return await _context.FichasAgro.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
