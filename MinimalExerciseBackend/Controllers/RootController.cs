using Microsoft.AspNetCore.Mvc;

namespace MinimalExerciseBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RootController : Controller
    {
        private readonly Root rootData;

        public RootController(Root datiList)
        {
            this.rootData = datiList;
        }




        /*[HttpGet(Name = "GetRoot")]
        public IEnumerable<Root> Get()
        {
            return null;
        }*/

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }
    }
}
