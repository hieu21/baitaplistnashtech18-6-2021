using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using bai15.Models;
using bai15.Services;
using Microsoft.AspNetCore.Http;

namespace bai15.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {


        private readonly IStudentServices _studentService;
        public StudentController(IStudentServices studentService)
        {
            _studentService = studentService;
        }


        [HttpGet]
        public List<Student> Get()
        {
            var result = _studentService.GetStudent();

            return result;
        }
        [HttpPost]
        public ActionResult Post(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existStudent =  _studentService.Add(student);
                    if (existStudent > 0)
                    {
                        return Ok(existStudent);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }
        [HttpPut]
        public ActionResult Put(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     _studentService.Edit(student);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _studentService.Delete(id);

            return NoContent();
        }
       

    }
}
