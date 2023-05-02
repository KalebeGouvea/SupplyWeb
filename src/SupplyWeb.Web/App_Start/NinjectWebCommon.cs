using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using System;
using SupplyWeb.Application.Services;
using SupplyWeb.Infra.Data.Repositories;
using SupplyWeb.Domain.Interfaces;
using SupplyWeb.Infra.Data.Context;
using SupplyWeb.Infra.IoC;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Supply.Web.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Supply.Web.Web.App_Start.NinjectWebCommon), "Stop")]

namespace Supply.Web.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            DependencyContainer.RegisterServices(kernel);
            return kernel;
        }
    }
}
