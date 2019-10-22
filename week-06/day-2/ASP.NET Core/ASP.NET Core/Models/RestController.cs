using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Models
{
    [Route("api")]
    public class RestController : Controller
    {
        static int greetCounter;
        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            greetCounter++;
            Greeting greeting = new Greeting();
            greeting.Id = greetCounter;
            greeting.Content = $"Hello, {name}!";
            return greeting;
        }
    }
}