using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionSample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SessionSample.Extensions;
using Microsoft.AspNetCore.Http;

namespace SessionSample.Controllers
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
            var list = new List<int>()
            {
                5,67,9,8
            };
            HttpContext.Session.Set<List<int>>("data", list);

            var val = HttpContext.Session.Get<List<int>>("data");
            return View();
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
