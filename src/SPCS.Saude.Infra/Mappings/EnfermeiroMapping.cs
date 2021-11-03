using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class EnfermeiroMapping : IEntityTypeConfiguration<Enfermeiro>
    {
        public void Configure(EntityTypeBuilder<Enfermeiro> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Email)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Cpf)
                .IsRequired()
                .HasColumnType("varchar(14)");


            builder.Property(a => a.Sexo)
               .IsRequired()
               .HasColumnType("varchar(9)");

            builder.Property(a => a.DataNascimento)
                .IsRequired();

            builder.Property(a => a.Telefone)
               .IsRequired()
               .HasColumnType("varchar(11)");

            builder.Property(a => a.Coren)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Enfermeiros");
        }
    }
}
