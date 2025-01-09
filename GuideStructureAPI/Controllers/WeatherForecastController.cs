using BusinessLogic.Commons;
using BusinessLogic.Security;
using BusinessLogicInterfaces.Commons;
using Entities.Base;
using EntitiesInterfaces.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GuideStructureAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")] // Ruta explícita para mayor claridad
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(RequestDTO requestDTO)
        {
            object ss = JsonSerializer.Deserialize<object>(requestDTO.Value.ToString());
            IExchangeRateBL exchangeRateBL = new ExchangeRateBL();
            exchangeRateBL.Get();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
