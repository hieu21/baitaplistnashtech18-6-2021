using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bai7.Models;
using Microsoft.AspNetCore.Http;

namespace bai7.Controllers
{
    public class RookiesController : Controller
    {
        // static List<PersonModel> persons = new List<PersonModel>();
        private readonly Service _service;
        public RookiesController(Service service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

            return View(_service.Get());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstName,LastName,Gender,Dob,PhoneNumber,Email")] PersonModel person)
        {

            if (ModelState.IsValid)
            {
                _service.Add(person);
                return RedirectToAction(nameof(Index));
            }

            return View(person);
        }


        public IActionResult Edit(int phoneNumber)
        {
            var a = _service.Get(phoneNumber);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("FirstName,LastName,Gender,Dob,PhoneNumber,Email")] PersonModel person)
        {

            var a = _service.Get(person.PhoneNumber);
            if (a != null)
            {
                _service.Edit(person);
                return RedirectToAction("Index");
            }

            return View(a);
        }


        public IActionResult Delete(PersonModel person)
        {
            var a = _service.Get(person.PhoneNumber);
            if (a != null)
            {
                _service.Delete(person.PhoneNumber);
                
                return RedirectToAction("Index");
            }

            return View(a);

        }
        public IActionResult Detail(int phoneNumber)
        {
            var a = _service.Get(phoneNumber);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail([Bind("FirstName,LastName,Gender,Dob,PhoneNumber,Email")] PersonModel person)
        {

            var a = _service.Get(person.PhoneNumber);
            if (a != null)
            {
                _service.Delete(person.PhoneNumber);
                var b = this.HttpContext.Session.GetString("person");
                HttpContext.Session.SetString("person", $"{person.LastName}");
                TempData["personDelete"] = $"Person {person.LastName} was removed from the list successfully! ";
                return RedirectToAction("Index");
                
            }

            return View(a);
        }


    }
}
