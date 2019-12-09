using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AndrewPino.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AndrewPino.Controllers
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
        
        [Route("Resume")]
        public IActionResult Resume()
        {
            return View();
        }
        
        [Route("Research")]
        public IActionResult Research()
        {
            return View();
        }
        
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult References()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}