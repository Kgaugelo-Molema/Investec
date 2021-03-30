using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Movies.Helpers;
using Movies.Model;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        /// <summary>
        /// Simultaneously query Chuck and Swapi endpoints
        /// </summary>
        /// <param name="category">Joke category name</param>
        /// <param name="character">Star Wars character name</param>
        [Authorize]
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
