using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fp_sys_csharp_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries.Get()[rng.Next(Summaries.Get().Count)]
                })
                .ToArray();
        }

        [HttpGet("f-sharp")]
        public IActionResult GetFSharp()
        {
            var weatherForecast = ClassLibrary1.FSharpWeatherForecast.weatherForecast;
            return Ok(weatherForecast);
        }
    }
}