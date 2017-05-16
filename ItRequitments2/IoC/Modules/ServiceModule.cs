﻿using Autofac;
using ItRequitment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ItRequitment.IoC.Modules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServiceModule)
            .GetTypeInfo()
            .Assembly;

            builder.RegisterAssemblyTypes(assembly)
            .Where(x => x.IsAssignableTo<IService>())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            builder.RegisterType<Encrypter>()
            .As<IEncrypter>()
            .SingleInstance();
        }
    }
}