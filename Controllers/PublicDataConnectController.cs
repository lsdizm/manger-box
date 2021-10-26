using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public dynamic Get()
        {
            return new
            {
                TypeName = "public-data",
                DateTime = DateTime.Now,                
            };
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
