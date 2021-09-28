using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class FichaAgroMapping : IEntityTypeConfiguration<FichaAgro>
    {
        public void Configure(EntityTypeBuilder<FichaAgro> builder)
        {
            builder.HasKey(a => new { a.FichaId, a.AgrotoxicoId });

            builder.HasOne(a => a.Ficha)
                .WithMany(a => a.Agrotoxicos)
                .HasForeignKey(a => a.FichaId);

            builder.HasOne(a => a.Agrotoxico)
                .WithMany(a => a.Fichas)
                .HasForeignKey(a => a.AgrotoxicoId);

            builder.ToTable("FichaAgro");
        }
    }
}
