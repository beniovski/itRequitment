using Autofac;
using ItRequitment.Core.Repositories;
using System.Linq;
using System.Reflection;

namespace ItRequitment.Infrastructure.IoC
{
    public class RepositoryModules : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            var assembly = typeof(RepositoryModules).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<IRepository>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

        }
    }
}