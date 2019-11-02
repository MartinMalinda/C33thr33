using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private UtilityService us { get; set; }

        public HomeController(UtilityService us)
        {
            this.us = us;
        }

        [Route("")]
        public IActionResult Index()
        {
           return RedirectToAction("useful");
        }

        [Route("useful")]
        public IActionResult Useful()
        {
            return View();
        }

        [Route("useful/colored")]
        public IActionResult Background()
        {
            return View("background", us.RandomColor());
        }

        [HttpGet]
        [Route("useful/email")]
        public IActionResult Email(string Email)
        {
            return View("Email", us.ValidateEmail(Email));
        }
    }
}