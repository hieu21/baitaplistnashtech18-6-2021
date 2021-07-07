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
    public class BookController : ControllerBase
    {


        private readonly IBookService _Service;
        public BookController(IBookService Service)
        {
            _Service = Service;
        }


        [HttpGet]
        public List<Book> Get()
        {
            var result = _Service.GetBooks();

            return result;
        }
        [HttpPost]
        public ActionResult Post(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existBook =  _Service.Add(book);
                    if (existBook > 0)
                    {
                        return Ok(existBook);
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
        public ActionResult Put(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     _Service.Edit(book);

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
