using DemoInterfaceCalling.Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoInterfaceCalling.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMaster _master;
        public EmployeeController(IMaster master)
        {
            _master = master;
        }
        public IActionResult Index()
        {
            var getAllEmployee = _master._employee.GetAll();
            return View(getAllEmployee);
        }
    }
}
