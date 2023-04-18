using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAppCRUD
{
    //Pour plus d'inforamtions concernant le fichier global.asax et la classe MvcApplication
    //    Conculter ce lient
    //    https://learn.microsoft.com/fr-fr/previous-versions/aspnet/ms178473(v=vs.100)
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        protected void Application_BeginRequest()
        {
            //Code pour intercepter la requête
            string path = HttpContext.Current.Request.Path;
        }

    }
}
