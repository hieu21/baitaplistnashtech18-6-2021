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
    public class ClientController : ControllerBase
    {


        private readonly IClientService _Service;
        public ClientController(IClientService Service)
        {
            _Service = Service;
        }


        [HttpGet]
        public List<Client> Get()
        {
            var result = _Service.GetClients();

            return result;
        }
        [HttpPost]
        public ActionResult Post(Client client)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existClient =  _Service.Add(client);
                    if (existClient > 0)
                    {
                        return Ok(existClient);
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
        public ActionResult Put(Client client)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     _Service.Edit(client);

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
