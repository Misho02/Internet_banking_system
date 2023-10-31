using Internet.Banking.Application.Abstraction;
using Internet.Banking.Application.ViewModels;
using Internet_banking_system.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Internet_banking_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IHomeService _homeService;



        public HomeController(ILogger<HomeController> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            CarouselCustomerViewModel viewModel = _homeService.GetIndexViewModel();
            return View(viewModel);
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