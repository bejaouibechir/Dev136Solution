using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSec.Controllers
{

   
    public class AdministratorsController : Controller
    {
        // GET: Administrators
        
        [Authorize]
        public ActionResult Manage()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Admins() {
        
            return View();
        }

        [Authorize(Roles = "HR")]
        public ActionResult Hrs()
        {
            return View();
        }

    }
}