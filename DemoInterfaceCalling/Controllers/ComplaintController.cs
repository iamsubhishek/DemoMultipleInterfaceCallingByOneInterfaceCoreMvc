using DemoInterfaceCalling.Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoInterfaceCalling.Controllers
{
    public class ComplaintController : Controller
    {
        private readonly IMaster _master;
        public ComplaintController(IMaster master)
        {
            _master = master;
        }
        public IActionResult Index()
        {
            var getAllComplaints = _master._complaint.GetAll();
            
            return View(getAllComplaints);
        }
    }
}
