using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAppSec
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureSecurity();
        }

        //Cette methode va
        /*
         * 1. Créer trois rôles s'il n'existent pas (Administrator,HR,User)
         * 2. Créer un tout premier utilisateur et lui affecter le rôle d'administrateur
         * */
        private void ConfigureSecurity()
        {
            UserStore<IdentityUser> userstore = new UserStore<IdentityUser>();
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>();

            UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(userstore);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);

            if(!roleManager.RoleExists("Administrator"))
            {
                IdentityRole role = new IdentityRole("Administrator");
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("HR"))
            {
                IdentityRole role = new IdentityRole("HR");
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("User"))
            {
                IdentityRole role = new IdentityRole("User");
                roleManager.Create(role);
            }

            /*Utiliser ce code pour créer un nouvel utilisateur*/
            //IdentityUser user = userManager
            //    .Users.SingleOrDefault(u => u.Email == "me780411@gmail.com");
            //if (user == null)
            //{
            //    IdentityUser superadmin = new IdentityUser
            //    {
            //        UserName = "Bechir",
            //        Email = "me780411@gmail.com",
            //    };
            //    IdentityResult result =  userManager.Create(superadmin,"Test123++");

            //    if (result.Succeeded)
            //    {
            //        userManager.AddToRole(superadmin.Id, "Administrator");
            //    }
            //}


        }
    }
}
