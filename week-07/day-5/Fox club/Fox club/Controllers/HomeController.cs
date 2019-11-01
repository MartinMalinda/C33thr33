using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foxclub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fox_club.Controllers
{
    public class HomeController : Controller
    {
        private LoFService LoFS { get; set; }
        public HomeController(LoFService LoFS)
        {
            this.LoFS = LoFS;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            LoFS.AddFox(name);
            return RedirectToAction("information", "Home", new { Name = name });
        }

        [HttpGet("")]
        public IActionResult Information(string name)
        {
            if (name == null)
            {
                return RedirectToAction("login");
            }
            return View(LoFS.FindFoxByName(name));
        }

        [HttpGet("nutrition")]
        public IActionResult Nutrition(string name)
        {
            if (name == null)
            {
                return RedirectToAction("login");
            }
            return View(LoFS.FindFoxByName(name));
        }

        [HttpGet("nutrition")]
        public IActionResult NutritionSet(string name)
        {
            if (name == null)
            {
                return RedirectToAction("login");
            }
            return View(LoFS.FindFoxByName(name));
        }




        //[Route("allfoxes")]
        //public IActionResult Allfoxes()
        //{
        //    return View();
        //}
    }
}