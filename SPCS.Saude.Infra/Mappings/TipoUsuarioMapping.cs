using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.Infra.Mappings
{
    public class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Descricao)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.ToTable("TiposUsuario");
        }
    }
}
