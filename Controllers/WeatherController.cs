using Lr9.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lr9.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;
        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetWeather(string cityName)
        {
            try
            {
                var weather = await _weatherService.GetWeather(cityName);
                return View("Weather", weather);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}