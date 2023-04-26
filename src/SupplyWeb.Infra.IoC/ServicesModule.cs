using Ninject.Modules;
using SupplyWeb.Application.Services;
using SupplyWeb.Domain.Interfaces;
using SupplyWeb.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.IoC
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            //Services
            Bind<IProductService>().To<ProductService>();
            Bind<IInboundService>().To<InboundService>();
            Bind<IOutboundService>().To<OutboundService>();

            //Repositories
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IInboundRepository>().To<InboundRepository>();
            Bind<IOutboundRepository>().To<OutboundRepository>();
        }
    }
}
