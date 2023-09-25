using Microsoft.AspNetCore.Http;
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


        [HttpGet("GetData")]
        public IActionResult GetData(string? title)
        {

            if (datiList != null)

                if (!string.IsNullOrEmpty(title))

                {
                    var filteredData = datiList.data.contents.Where(obj => obj.title.Contains(title)).ToArray();
                    return Ok(filteredData);

                }
                else
                    return Ok(datiList.data.contents);


            else
                return NotFound();
        }

        [HttpDelete("RemoveContentFromId")]
        public IActionResult RemoveContentFromId(string contentId)
        {

            if (datiList != null && datiList.data.contents.Any(r => r.contentId == contentId))
            {
                datiList.data.contents.RemoveAll(r => r.contentId == contentId);

                return Ok(datiList);
            }
            else
            {
                return NotFound();
            }


        }
    }

        
          
        

    }
