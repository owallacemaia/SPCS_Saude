using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class AgrotoxicoMapping : IEntityTypeConfiguration<Agrotoxico>
    {
        public void Configure(EntityTypeBuilder<Agrotoxico> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Tipo)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.PrincipioAtivo)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Agrotoxicos");
        }
    }
}
