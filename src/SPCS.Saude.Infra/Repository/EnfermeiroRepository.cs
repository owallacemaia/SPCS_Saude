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
    public class EnfermeiroRepository : IEnfermeiroRepository
    {
        private readonly PrincipalDbContext _context;

        public EnfermeiroRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Enfermeiro enfermeiro)
        {
            _context.Enfermeiros.Add(enfermeiro);
        }

        public async Task<Enfermeiro> ObterPorId(Guid id)
        {
            return await _context.Enfermeiros.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Enfermeiro>> ObterTodos()
        {
            return await _context.Enfermeiros.AsNoTracking().ToListAsync();
        }

        public async Task<Enfermeiro> ObterInformacoesPorUsuarioId(Guid id)
        {
            return await _context.Enfermeiros.AsNoTracking().FirstOrDefaultAsync(a => a.UsuarioId == id);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
