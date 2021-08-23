using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase //weatherforecast controller extends controllerbase
    {
        private static readonly string[] Summaries = new[] //string[]= string array; new[]= new array 
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger; //<> = type indicator 

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger; //private logger is equal logger that is being requested
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random(); //variable = range that is being a new random number 
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast //return a random number between 1-5 
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)] 
            })
            .ToArray();
        }
    }
}
