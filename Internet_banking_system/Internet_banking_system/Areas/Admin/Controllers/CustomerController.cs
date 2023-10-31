using Internet.Banking.Application.Abstraction;
using Internet.Banking.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Internet.Banking.Infrastructure.Database;

namespace Internet_banking_system.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CustomerController : Controller
    {
        ICustomerAppService _customerAppService;
        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }
        public IActionResult Index()
        {
            //return View();
            IList<Customer> customers = _customerAppService.Select();
            return View(customers);
        }
    }
}
