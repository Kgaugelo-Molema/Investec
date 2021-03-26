using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Chuck" };
        }

        public static async Task<string> GetMessage()
        {
            var client = new HttpClient();
            var stringTask = client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            return await stringTask;
        }
    }
}
