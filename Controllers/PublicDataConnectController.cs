using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangerBox.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MangerBox.Controllers
{
    [ApiController]
    [Route("public-data")]
    public class PublicDataConnectController : ControllerBase
    {
        public PublicDataConnectController()
        {
            //   
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var repositories = new Repositories();
            var result = await repositories.GetTest().ConfigureAwait(false);
            return Ok(result);
        }


        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        // private readonly ILogger<WeatherForecastController> _logger;

        // public WeatherForecastController(ILogger<WeatherForecastController> logger)
        // {
        //     _logger = logger;
        // }

        
    }
}
