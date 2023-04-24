using SupplyWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("products");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("id");

            Property(p => p.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.RegistrationNumber)
                .HasColumnName("registration_number")
                .HasMaxLength(20)
                .IsRequired();

            Property(p => p.Manufacturer)
                .HasColumnName("manufacturer")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Type)
                .HasColumnName("type")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Description)
                .HasColumnName("description")
                .HasMaxLength(256);
        }
    }
}
