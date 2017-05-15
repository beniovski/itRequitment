﻿using Autofac;
using ItRequitment.Infrastructure.IoC;
using ItRequitment.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ItRequitments2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutofacConfig.ConfigureContainer();
             

        }
    }
}
