using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bai6.Models;
using System.Text;

namespace bai6.Controllers
{
    public class RookiesController : Controller
    {

        List<PersonModel> persons = new List<PersonModel>(){
            new PersonModel("nguyen van", "ba", "male", new DateTime(1995, 1, 2), 0123456, "HP", 26, "yes"),
            new PersonModel("nguyen van", "bon", "male", new DateTime(2002, 1, 2), 0123456, "NA", 19, "yes"),
            new PersonModel("nguyen van", "nam", "female", new DateTime(2000, 1, 2), 0123456, "HN", 21, "no"),
            new PersonModel("nguyen van", "sau", "male", new DateTime(2003, 1, 2), 0123456, "TH", 18, "yes"),
            new PersonModel("nguyen van", "bay", "male", new DateTime(1999, 1, 2), 0123456, "HN", 22, "no"),
            new PersonModel("nguyen van", "tam", "male", new DateTime(1997, 1, 2), 0123456, "SG", 24, "yes"),
        };
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult GetMale(){
             List<PersonModel> model = persons.Where(item => item.Gender == "male").ToList();
            //var model1 = from item in persons where item.Gender == "maile" select item;
            return View(model);
        }
        public IActionResult GetOldest()
        {
            var oldest = persons.Select(n => n.Age).Max();
            List<PersonModel> model = persons.Where(item => item.Age == oldest).ToList();
            return View(model);
        }

        public IActionResult GetFullNameOnly()
        {
            List<PersonModel> fullName = persons.Select(n => n).ToList();
            return View(fullName);
        }
        public IActionResult GetYearOfBirth2000()
        {
            List<PersonModel> birth = persons.Where(n => n.Dob.Year == 2000).ToList();
            return View(birth);
        }
        public IActionResult GetYearOfBirth2000Up()
        {
            List<PersonModel> birth = persons.Where(n => n.Dob.Year > 2000).ToList();
            return View(birth);
        }
        public IActionResult GetYearOfBirth2000Down()
        {
            List<PersonModel> birth = persons.Where(n => n.Dob.Year < 2000).ToList();
            return View(birth);
        }
        public IActionResult Csv()
        {
            var builder = new StringBuilder();
            builder.AppendLine("firstName,lastName");
            foreach (var person in persons)
            {
                builder.AppendLine($"{person.FirstName},{person.LastName}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "person.csv");
        }

    }
}
