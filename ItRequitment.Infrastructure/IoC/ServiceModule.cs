using Autofac;
using ItRequitment.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ItRequitment.Infrastructure.IoC
{
    public class ServiceModules : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            var assembly = typeof(ServiceModules).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<IService>())
                .AsImplementedInterfaces()
                .InstancePerMatchingLifetimeScope();
        }

    }
}