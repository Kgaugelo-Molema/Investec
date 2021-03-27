using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Movies.Model;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async Task<SearchFilter> Get([FromQuery] string category, [FromQuery] string character)
        {
            var json = await this.GetMessage($"{ClientHelper.peopleUrl}{character}").Result.Content.ReadAsStringAsync();
            var swapiData = JsonConvert.DeserializeObject<SwapiData>(json);

            json = await this.GetMessage($"{ClientHelper.jokeUrl}{category}").Result.Content.ReadAsStringAsync();
            var jokeData = JsonConvert.DeserializeObject<JokeData>(json);

            return new SearchFilter(swapiData.results, jokeData.result);
        }
    }
}
