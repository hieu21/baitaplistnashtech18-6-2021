using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bai10.Models;

namespace bai10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RookiesController : ControllerBase
    {
        public RookiesController() { }
        [HttpGet]
        public ActionResult<List<ServerModel>> GetAll() => Service.GetAll();

        [HttpGet("{id}")]
        public ActionResult<ServerModel> Get(int id)
        {
            var a = Service.Get(id);

            if (a == null)
                return NotFound();

            return a;
        }
        [HttpPost]
        public IActionResult Create(ServerModel server)
        {
            
            Service.Add(server);
            return CreatedAtAction(nameof(Create), new { id = server.Id }, server);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, ServerModel server)
        {
            
            if (id != server.Id)
                return BadRequest();

            var a = Service.Get(id);
            if (a is null)
                return NotFound();

            Service.Update(server);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            var a = Service.Get(id);

            if (a is null)
                return NotFound();

            Service.Delete(id);

            return NoContent();
        }
    }
}
