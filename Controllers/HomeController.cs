using System.Diagnostics;
using InkCraft.Models;
using Microsoft.AspNetCore.Mvc;

namespace InkCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        
    }
}
