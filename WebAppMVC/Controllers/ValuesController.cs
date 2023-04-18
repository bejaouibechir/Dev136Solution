using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    // controller/action
    public class ValuesController : Controller 
    {
        // GET: Values
        public ActionResult Index() //localhost:8080/values/Index
        {
            return View();
        }
    }
}