using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoASPNETCore.Models;

namespace DemoASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly GreeterServiceReference.GreeterServiceClient _greeter;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _greeter = new GreeterServiceReference.GreeterServiceClient();
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.Greeting = _greeter.Greet("user");
            return View(vm);
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
