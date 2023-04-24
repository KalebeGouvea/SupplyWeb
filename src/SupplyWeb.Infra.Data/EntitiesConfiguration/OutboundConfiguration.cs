using SupplyWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.Data.EntitiesConfiguration
{
    public class OutboundConfiguration : EntityTypeConfiguration<Outbound>
    {
        public OutboundConfiguration()
        {
            ToTable("inbounds");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("id");

            Property(p => p.Quantity)
                .HasColumnName("quantity")
                .IsRequired();

            Property(p => p.Date)
                .HasColumnName("date")
                .IsRequired();

            Property(p => p.Location)
                .HasColumnName("location")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.ProductId)
                .HasColumnName("product_id")
                .IsRequired();
        }
    }
}
