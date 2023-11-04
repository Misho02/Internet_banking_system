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
            IList<Customer> customers = _customerAppService.Select();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _customerAppService.Create(customer);
            return RedirectToAction(nameof(CustomerController.Index));
        }
    }
}
