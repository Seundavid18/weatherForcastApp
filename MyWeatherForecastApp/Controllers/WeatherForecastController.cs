using Microsoft.AspNetCore.Mvc;

namespace MyDotnetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Weather forecast fetched successfully.");
    }
}