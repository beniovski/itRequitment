using Autofac;
using Autofac.Integration.Mvc;
using ItRequitment.Infrastructure.IoC;
using System.Web.Mvc;
using System.Web.Routing;

namespace ItRequitment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutofacConfig.ConfigureContainer();
             

        }
    }
}
