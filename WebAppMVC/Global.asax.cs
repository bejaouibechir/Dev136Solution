using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAppMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginSession()
        {

        }

        protected void Application_EndSession()
        {
           
        }


        protected void Application_BeginRequest()
        {
          
        }

        protected void Application_EndRequest()
        {

        }



        protected void Application_End()
        {
            //Fermer une connexion vers un service web 
            //Librer un fichier ou une ressource
            //Tracer le moment de désactivation 
        }


    }
}
