using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var result = GetMessage().Result;
            return result;
        }

        public static async Task<string> GetMessage()
        {
            var client = new HttpClient();
            var stringTask = client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            return await stringTask;
        }
    }
}
