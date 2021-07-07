using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DI2.Services;

namespace DI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
       private readonly IServices _services;
       public TestController(IServices services){
           _services = services;
       }

       [HttpGet]
       public String Get(){
           return _services.Get();
       }
    }
}
