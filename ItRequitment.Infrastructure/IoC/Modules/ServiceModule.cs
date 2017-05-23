using Autofac;
using ItRequitment.Infrastructure.Services;
using System.Linq;
using System.Reflection;

namespace ItRequitment.Infrastructure.IoC.Modules
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
            .As<IEncrypter>().SingleInstance();
        }
    }
}