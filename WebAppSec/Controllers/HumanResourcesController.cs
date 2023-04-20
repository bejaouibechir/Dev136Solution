using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSec.Controllers
{
    [Authorize(Roles = "Administrator,HR")]
    public class HumanResourcesController : Controller
    {
        // GET: HumanResources
        
        public ActionResult Management()
        {
            return View();
        }
    }
}