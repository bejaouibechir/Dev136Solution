using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppCoreNouvelle.Models;
using WebAppCoreNouvelle.Services;

namespace WebAppCoreNouvelle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;


        //Injection de dépendance
        public HomeController(ISingletonService singletonService, 
              IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
           


            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

        public IActionResult Conact()
        {
            
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}