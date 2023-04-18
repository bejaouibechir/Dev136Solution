using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Somme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Somme(int op1,int op2)
        {
            int result = op1 + op2;
            
            return View();
        }
    }
}