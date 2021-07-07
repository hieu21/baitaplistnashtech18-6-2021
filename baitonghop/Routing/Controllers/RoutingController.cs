using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.Models;
using Microsoft.AspNetCore.Http;

namespace Routing.Controllers
{
    public class RoutingController : Controller
    {

        public IActionResult Index()
        {
            return Content("hello this is routing");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("FirstAction")]
        public IActionResult FirstAction(){
            return Content("this is a FirstAction");
        }
        [Route("Routing/SecondAction")]
        public IActionResult SecondAction(){
            return Content("this is a SecondAction");
        }
        [Route("Routing/ThirdAction")]
        public IActionResult ThirdAction(){
            return Content("this is a ThirdAction");
        }

    }
}
