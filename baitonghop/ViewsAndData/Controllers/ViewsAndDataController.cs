using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewsAndData.Models;


namespace ViewsAndData.Controllers
{
    public class ViewsAndDataController : Controller
    {
       

        public IActionResult Index()
        {

            return View();
        }

       public IActionResult UsingViewData()
        {
            ViewData["Greeting"] = "Hello World";
            return View();
        }
        public IActionResult UsingViewBag()
        {
             ViewBag.ExampleValue = "this is a example";
            return View();
        }
        public IActionResult UsingStrongType()
        {
            
            return View(new PersonModel{
                Age=15,
                Name="John"
            });
        }

    }
}
