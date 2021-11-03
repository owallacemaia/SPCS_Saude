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
            _context.Attach(enfermeiro.TipoUsuario);
            _context.Enfermeiros.Add(enfermeiro);
        }

        public void Atualizar(Enfermeiro enfermeiro)
        {
            _context.Enfermeiros.Update(enfermeiro);
        }

        public async Task<Enfermeiro> EnfermeiroFiltro(string cpf = null, string corem = null)
        {
            return await _context.Enfermeiros.AsNoTracking().FirstOrDefaultAsync(e => e.Cpf == cpf || e.Coren == corem);
        }

        public async Task<Enfermeiro> ObterPorId(Guid id)
        {
            return await _context.Enfermeiros.AsNoTracking()
                .Include(m => m.TipoUsuario)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Enfermeiro>> ObterTodos()
        {
            return await _context.Enfermeiros.AsNoTracking()
                .Include(m => m.TipoUsuario)
                .ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
