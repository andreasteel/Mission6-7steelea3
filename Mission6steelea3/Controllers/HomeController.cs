using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6steelea3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6steelea3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        //constructor
        public HomeController(ILogger<HomeController> logger, MovieContext something)
        {
            _logger = logger;
            _movieContext = something;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm ()
        {
            return View("movieForm");
        }

        [HttpPost]
        public IActionResult MovieForm (MovieFormResponse mfr)
        {
            _movieContext.Add(mfr);
            _movieContext.SaveChanges();
            return View("Confirmation", mfr);
        }

        [HttpGet]
        public IActionResult Forms()
        {
            
            return View();
        }

        public IActionResult Podcast()
        {
            return View("Podcast");
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
