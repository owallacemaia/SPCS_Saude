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

            builder.Property(a => a.Coren)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Enfermeiros");
        }
    }
}
