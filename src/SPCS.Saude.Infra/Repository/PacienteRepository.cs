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
    public class PacienteRepository : IPacienteRepository
    {
        private readonly PrincipalDbContext _context;

        public PacienteRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
        }

        public void Atualizar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
        }

        public async Task<Paciente> ObterPorCpf(string cpf)
        {
            return await _context.Pacientes.AsNoTracking()
                .Include(a => a.Endereco)
                .FirstOrDefaultAsync(p => p.Cpf == cpf);
        }

        public async Task<Paciente> ObterPorId(Guid id)
        {
            return await _context.Pacientes.AsNoTracking()
                .Include(a => a.Endereco)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Paciente>> ObterTodos()
        {
            return await _context.Pacientes.AsNoTracking()
                .Include(a => a.Endereco)
                .ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Paciente>> ObterPacientesFichas()
        {
            return await _context.Pacientes.AsNoTracking()
                .Include(a => a.Fichas)
                .ToListAsync();
        }
    }
}
