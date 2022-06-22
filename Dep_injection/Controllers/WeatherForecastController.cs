using Microsoft.AspNetCore.Mvc;

namespace Dep_injection.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
        }
        //[HttpGet(Name = "Getcategry")]
        //public List<Category> GetCat()
        //{
        //    CategoryRepository categoryRepository = new CategoryRepository();
        //    //List<Category> categories = categoryRepository.GetCategories();

        //    return categoryRepository.GetCategories().ToList();
        //}

        //[HttpGet(Name = "GetCategory")]
        //public async Task<IActionResult> GetCAT()
        //{
        //    CategoryRepositor cr=new CategoryRepositor();
        //    List<Category> categories=new List<Category>();
        //    categories = cr.GetCategories();
        //    return Ok(categories);
        //}
    }
}