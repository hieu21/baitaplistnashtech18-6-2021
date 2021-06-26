using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bai7.Models;

namespace bai7.Controllers
{
    public class RookiesController : Controller
    {
        static List<PersonModel> persons = new List<PersonModel>();

        public IActionResult Index()
        {

            return View(persons);
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
                persons.Add(person);
                return RedirectToAction(nameof(Index));
            }

            return View(person);
        }


        public IActionResult Edit(int phoneNumber)
        {
            PersonModel a = persons.SingleOrDefault(x => x.PhoneNumber == phoneNumber);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("FirstName,LastName,Gender,Dob,PhoneNumber,Email")] PersonModel person)
        {

            PersonModel a = persons.SingleOrDefault(x => x.PhoneNumber == person.PhoneNumber);
            if (a != null)
            {
                a.FirstName = person.FirstName;
                a.LastName = person.LastName;
                a.Dob = person.Dob;
                a.Gender = person.Gender;
                a.PhoneNumber = person.PhoneNumber;
                a.Email = person.Email;
                return RedirectToAction("Index");
            }

            return View(person);
        }


        public IActionResult Delete(int phoneNumber)
        {
            PersonModel person = persons.SingleOrDefault(x => x.PhoneNumber == phoneNumber);
            persons.Remove(person);

            return View("Index", persons);
        }


    }
}
