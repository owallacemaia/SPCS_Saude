using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Crm)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Medicos");
        }
    }
}
