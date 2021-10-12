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

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(a => a.Sexo)
               .IsRequired()
               .HasColumnType("varchar(9)");

            builder.Property(a => a.DataNascimento)
                .IsRequired();

            builder.Property(a => a.Telefone)
               .IsRequired()
               .HasColumnType("varchar(11)");

            builder.Property(a => a.Escolaridade)
               .IsRequired()
               .HasColumnType("varchar(100)");

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
