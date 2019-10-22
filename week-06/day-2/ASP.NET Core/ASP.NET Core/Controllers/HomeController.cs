using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
       
        [Route("")]
        public string Index()
        {

            //Request.QueryString()
            return "Hello from the Controller!";

        }
    }
}