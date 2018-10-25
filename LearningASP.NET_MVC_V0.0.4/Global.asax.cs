using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LearningASP.NET_MVC_V0._0._4.Controllers;

namespace LearningASP.NET_MVC_V0._0._4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalFilters.Filters.Add(new TimerAttribute()); //GlobalFilters are added to all actions that are made.
        }
    }
}
