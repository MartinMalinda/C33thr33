using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        static List<BankAccount> listOfPeople = new List<BankAccount>() {
        new BankAccount("Petr Kellner", 270000000000, "businessman", false),
        new BankAccount("Andrej Babiš", 71000000000, "criminal", true),
        new BankAccount("Donald Trump", 64495000000, "useful idiot", true),
        new BankAccount("Elon Musk", 486000000000, "visionary", false),
        new BankAccount("Jaromír Jágr", 1611700000, "hockey player", false)
        };

        [Route("")]
        public IActionResult Home()
        {
            return View();
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View(listOfPeople);
        }

        [HttpPost("CreateNew")]
        public IActionResult Create(string name, double balance, string occupation, bool badGuy)
        {
            listOfPeople.Add(new BankAccount(name,balance,occupation,badGuy));
            return RedirectToAction("Index");
        }

        [Route("Test")]
        public IActionResult Test()
        {
            return View();
        }
    }
}