using Autofac;
using System.Linq;
using System.Reflection;
using ItRequitment.Repositories;

namespace ItRequitment.IoC.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(RepositoryModule)
            .GetTypeInfo()
            .Assembly;

            builder.RegisterAssemblyTypes(assembly)
            .Where(x => x.IsAssignableTo<IRepository>())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        }

    }
}