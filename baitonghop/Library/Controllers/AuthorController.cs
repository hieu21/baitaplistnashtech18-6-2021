using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Http;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {


        private readonly IAuthorService _Service;
        public AuthorController(IAuthorService Service)
        {
            _Service = Service;
        }


        [HttpGet]
        public List<Author> Get()
        {
            var result = _Service.GetAuthors();

            return result;
        }
        [HttpPost]
        public ActionResult Post(Author author)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existAuthor =  _Service.Add(author);
                    if (existAuthor > 0)
                    {
                        return Ok(existAuthor);
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
        public ActionResult Put(Author author)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     _Service.Edit(author);

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

            _Service.Delete(id);

            return NoContent();
        }
       

    }
}
