using eShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Infra.Repository
{
    public class AmostraRepository : IAmostraRepository
    {
        private readonly PrincipalDbContext _context;

        public AmostraRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Amostra amostra)
        {
            _context.Amostras.Add(amostra);
        }

        public async Task<IEnumerable<Amostra>> ListarAsync()
        {
            return await _context.Amostras.AsNoTracking().ToListAsync();
        }

        public async Task<Amostra> ObterPorId(Guid id)
        {
            return await _context.Amostras.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
