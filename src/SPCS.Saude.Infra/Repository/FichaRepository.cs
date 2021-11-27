using eShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.Infra.Repository
{
    public class FichaRepository : IFichaRepository
    {
        private readonly PrincipalDbContext _context;

        public FichaRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Ficha ficha)
        {
            _context.Fichas.Add(ficha);
        }

        public void Atualizar(Ficha ficha)
        {
            _context.Fichas.Update(ficha);
        }

        public async Task<Ficha> ObterPorId(Guid id)
        {
            return await _context.Fichas.AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Ficha>> ListarAsync()
        {
            return await _context.Fichas.AsNoTracking().OrderBy(a => a.DataCadastro).ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
