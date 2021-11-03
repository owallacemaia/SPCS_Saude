using eShop.Core.Data;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Messages;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.Infra.Context
{
    public class PrincipalDbContext : DbContext, IUnitOfWork
    {
        public PrincipalDbContext(DbContextOptions<PrincipalDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Enfermeiro> Enfermeiros { get; set; }
        public DbSet<Enfermeiro> TiposUsuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<FichaAgro> FichasAgro { get; set; }
        public DbSet<Agrotoxico> Agrotoxicos { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Amostra> Amostras { get; set; }
        public DbSet<RefreshTokenData> RefreshTokens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PrincipalDbContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            return sucesso;
        }
    }
}
