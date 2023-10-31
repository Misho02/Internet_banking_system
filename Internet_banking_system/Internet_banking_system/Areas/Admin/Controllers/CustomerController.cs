using Microsoft.AspNetCore.Mvc;

namespace Internet_banking_system.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
