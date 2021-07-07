using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Logging.Models;


namespace Logging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
        // public ActionResult GetName()
        // {
        //     Program result = new Program();
        //     return Content(result.Name());
        // }
         private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public ActionResult Get()

        {
            _logger.LogInformation("Get request");
            var response = String.Format("{0}://{1}, {2} ,{3} {4}", HttpContext.Request.Scheme, HttpContext.Request.Host, HttpContext.Request.Path, HttpContext.Request.QueryString, HttpContext.Request.Body);
            return Content(response);
        }

    }
}
