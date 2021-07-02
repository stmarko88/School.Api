using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStudentBusinessLogic studentBusinessLogic;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStudentBusinessLogic studentBusinessLogic)
        {
            _logger = logger;
            this.studentBusinessLogic = studentBusinessLogic;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            bool tst = studentBusinessLogic.Test();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
