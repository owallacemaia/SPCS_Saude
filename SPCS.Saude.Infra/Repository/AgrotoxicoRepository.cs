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
    public class AgrotoxicoRepository : IAgrotoxicoRepository
    {
        private readonly PrincipalDbContext _context;

        public AgrotoxicoRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Agrotoxico agrotoxico)
        {
            _context.Agrotoxicos.Add(agrotoxico);
        }

        public void Atualizar(Agrotoxico agrotoxico)
        {
            _context.Agrotoxicos.Update(agrotoxico);
        }

        public async Task<Agrotoxico> ObterPorId(Guid id)
        {
            return await _context.Agrotoxicos.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Agrotoxico>> ObterTodos()
        {
            return await _context.Agrotoxicos.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
