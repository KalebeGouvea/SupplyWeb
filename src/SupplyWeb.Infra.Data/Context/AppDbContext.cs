using SupplyWeb.Domain.Entities;
using SupplyWeb.Infra.Data.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppConnectionString") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Inbound> Inbounds { get; set; }
        public DbSet<Outbound> Outbounds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new InboundConfiguration());
            modelBuilder.Configurations.Add(new OutboundConfiguration());
        }
    }
}
