using Core.Entities.Contribuyentes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration
{
    internal class ComprobanteFiscalConfiguration : IEntityTypeConfiguration<ComprobanteFiscal>
    {
        public void Configure(EntityTypeBuilder<ComprobanteFiscal> builder)
        {
            builder.Property(comprobante => comprobante.Id).IsRequired();
            builder.Property(comprobante => comprobante.Ncf).IsRequired().HasMaxLength(11);
            builder.Property(comprobante => comprobante.Monto).IsRequired().HasColumnType("decimal(18,2)"); ;
        }
    }
}
