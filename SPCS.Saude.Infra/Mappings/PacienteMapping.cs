using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Endereco)
                .WithOne(a => a.Paciente)
                .HasForeignKey<Endereco>(a => a.PacienteId);

            builder.HasMany(a => a.Fichas)
                .WithOne(a => a.Paciente)
                .HasForeignKey(a => a.PacienteId);

            builder.ToTable("Pacientes");
        }
    }
}
