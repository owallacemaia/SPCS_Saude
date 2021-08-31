using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
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

            builder.HasOne(a => a.Endereco)
                .WithOne(a => a.Usuario);

            builder.ToTable("Usuarios");
        }
    }
}
