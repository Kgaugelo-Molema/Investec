using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Helpers;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        /// <summary>
        /// List all Chuck Noris joke categories
        /// </summary>
        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await this.GetMessage(ClientHelper.chuckUrl).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<string>>(result);
        }
    }
}
