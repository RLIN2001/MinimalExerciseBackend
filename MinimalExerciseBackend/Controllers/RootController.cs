using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System.IO;

namespace MinimalExerciseBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RootController : ControllerBase
    {
        private static readonly Root datiList = LoadData();

        private static Root LoadData()
        {
            var jsonFilePath = "MyData/data.json";
            var jsonContent = System.IO.File.ReadAllText(jsonFilePath);
            Root data = JsonConvert.DeserializeObject<Root>(jsonContent);
            return data;
        }


        [HttpGet]
        public IActionResult GetDatiList()
        {
            if (datiList != null)
                return Ok(datiList);
            else
                return NotFound();
        }

    }
}