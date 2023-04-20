using Microsoft.AspNetCore.Mvc;
using WebAppCoreNouvelle.Services;

namespace WebAppCoreNouvelle.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _service;

        //Injection de dépendance au niveau du constructeur
        public EmployeesController(IEmployeeService service)
        {
           _service = service;
        }

        public IActionResult Index()
        {
            List<Employee> model = _service.ProcessData();
            return View(model);
        }
    }
}
