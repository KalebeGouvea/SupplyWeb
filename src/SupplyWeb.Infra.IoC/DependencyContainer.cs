using SupplyWeb.Application.Services;
using SupplyWeb.Infra.Data.Repositories;
using SupplyWeb.Domain.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IKernel kernel)
        {
            // Register Services
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IInboundService>().To<InboundService>();
            kernel.Bind<IOutboundService>().To<OutboundService>();

            // Register Repositories
            kernel.Bind<IProductRepository>().To<ProductRepository>();
            kernel.Bind<IInboundRepository>().To<InboundRepository>();
            kernel.Bind<IOutboundRepository>().To<OutboundRepository>();
        }
    }
}
