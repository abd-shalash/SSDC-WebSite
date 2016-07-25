
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSiteUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
//            routes.MapRoute(
//"Default",                                       // Route name  
//"{controller}/{action}/{name}",                    // URL w/ params  
//new { controller = "User", action = "Index", name = "tab" }  // Param defaults  
//);
            // ModelBinders.Binders.Add(typeof(loginInfo),new LoginInfoModelBinder());
        }
    }
}
