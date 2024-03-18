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
    internal class ContribuyenteConfiguration : IEntityTypeConfiguration<Contribuyente>
    {
        public void Configure(EntityTypeBuilder<Contribuyente> builder)
        {

            builder.Property(contribuyente=> contribuyente.Id).IsRequired();
            builder.Property(contribuyente=> contribuyente.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(contribuyente => contribuyente.IsActivo).IsRequired();
            builder.HasOne(contribuyente => contribuyente.TipoContribuyente).WithMany(
                ).HasForeignKey(contribuyente => contribuyente.TipoContribuyenteId);
            builder.HasMany(contribuyente => contribuyente.ComprobantesFiscales).WithOne(comprobante => comprobante.Contribuyente).HasForeignKey(comprobante => comprobante.ContribuyenteId);
        
        }
    }
}
