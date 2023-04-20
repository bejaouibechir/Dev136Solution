using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSec.Controllers
{
    public class VisitorsController : Controller
    {
        // GET: Visitors
        public ActionResult Index()
        {
            return View();
        }
    }
}