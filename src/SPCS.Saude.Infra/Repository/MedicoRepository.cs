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
    public class MedicoRepository : IMedicoRepository
    {
        private readonly PrincipalDbContext _context;

        public MedicoRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Medico medico)
        {
            _context.Medicos.Add(medico);
        }

        public async Task<Medico> ObterInformacoesPorUsuarioId(Guid id)
        {
            return await _context.Medicos.AsNoTracking().FirstOrDefaultAsync(a => a.UsuarioId == id);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<Medico> ObterPorId(Guid id)
        {
            return await _context.Medicos.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Medico>> ObterTodos()
        {
            return await _context.Medicos.AsNoTracking().ToListAsync();
        }
    }
}
