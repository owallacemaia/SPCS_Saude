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
    public class DiagnosticoMappings : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Ficha)
                .WithOne(a => a.Diagnostico);

            builder.ToTable("Diagnosticos");
        }
    }
}
