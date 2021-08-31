﻿using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PrincipalDbContext _context;

        public UsuarioRepository(PrincipalDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
        
        public void Adicionar(Usuario usuario)
        {
            _context.Attach(usuario.TipoUsuario);
            _context.Usuarios.Add(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }

        public async Task<Usuario> ObterPorEmail(string email)
        {
            return await _context.Usuarios.AsNoTracking().FirstOrDefaultAsync(a => a.Email == email);
        }

        public async Task<Usuario> ObterPorCpf(string cpf)
        {
            return await _context.Usuarios.AsNoTracking().Include(a => a.TipoUsuario).FirstOrDefaultAsync(a => a.Cpf == cpf);
        }

        public async Task<IEnumerable<Usuario>> ObterPorTipo(Guid tipoId)
        {
            return await _context.Usuarios.AsNoTracking().Where(a => a.TipoUsuario.Id == tipoId).ToListAsync();
        }

        public async Task<IEnumerable<Usuario>> ObterTodos()
        {
            return await _context.Usuarios.AsNoTracking().Include(a => a.TipoUsuario).ToListAsync();
        }

        public void GravarToken(RefreshTokenData refreshToken)
        {
            _context.RefreshTokens.Add(refreshToken);
        }

        public async Task<RefreshTokenData> ObterTokenUsuario(string email)
        {
            return await _context.RefreshTokens.AsNoTracking().FirstOrDefaultAsync(a => a.Email == email);
        }

        public async Task<Usuario> ObterPorId(Guid id)
        {
            return await _context.Usuarios.AsNoTracking().Include(a => a.TipoUsuario).FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Remover(Guid id)
        {
            _context.Remove(id);
        }
    }
}
