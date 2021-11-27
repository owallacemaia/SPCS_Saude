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
    public class AmostraMappings : IEntityTypeConfiguration<Amostra>
    {
        public void Configure(EntityTypeBuilder<Amostra> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(a => a.Ficha)
                .WithOne(a => a.Amostra);

            builder.ToTable("Amostras");
        }
    }
}
