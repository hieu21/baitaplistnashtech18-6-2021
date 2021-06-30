using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bai13.Model;
using bai13.Services;
using Microsoft.AspNetCore.Http;

namespace bai13.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {


        private readonly IService _service;
        public PersonController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Person>> Get() => _service.GetAll();
        [HttpGet("{id}")]
        public ActionResult<Person> GetById(int id)
        {
            var a = _service.Get(id);
            if (a == null)
                return NotFound();
            return a;
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            _service.Add(person);
            return CreatedAtAction(nameof(Post), new { id = person.Id }, person);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Person person)
        {

            if (id != person.Id)
                return BadRequest();

            var a = _service.Get(id);
            if (a is null)
                return NotFound();

            _service.Update(person);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var a = _service.Get(id);

            if (a is null)
                return NotFound();

            _service.Delete(id);

            return NoContent();
        }
        [HttpGet("/person-gender")]
        public ActionResult<List<Person>> FilterByGender(string gender)
        {
            var result = _service.FilterByGender(gender);
            
             return result;
        }
        [HttpGet("/person-birth-place")]
        public List<Person> FilterByBirthPlace(string birthPlace)
        {
            return _service.FilterByBirthPlace(birthPlace);

        }
        [HttpGet("/person-name")]
        public List<Person> FilterByName(string name)
        {
            return _service.FilterByName(name);
        }

    }
}
