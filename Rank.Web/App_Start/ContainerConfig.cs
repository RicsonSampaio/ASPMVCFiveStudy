using Autofac;
using Autofac.Integration.Mvc;
using Rank.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rank.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<RankedBeingInMemory>()
                .As<IRankedBeingData>()
                .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}