using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVCEFInMemory.Models;

namespace WebMVCEFInMemory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;

        public HomeController(ProductContext context)
        {
           _context = context;
            _context.Categories.Add(new Category { Id = 1, Name = "Voitures" });

            

        }

        public IActionResult Index()
        {
            List<Product> model = _context.Products.ToList();
            _context.Products.Add(new Product { Id = 1, Name = "Mercedes", Price = 55000 });
            _context.Products.Add(new Product { Id = 2, Name = "BMW", Price = 20000 });
            _context.Products.Add(new Product { Id = 3, Name = "Opel", Price = 23000 });
            return View(model);
        }
        


        public IActionResult Privacy()
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