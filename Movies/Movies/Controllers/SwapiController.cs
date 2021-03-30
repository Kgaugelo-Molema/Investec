using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Movies.Helpers;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        /// <summary>
        /// List all Star Wars charcaters
        /// </summary>
        [Authorize]
        [HttpGet]
        public async Task<SwapiData> Get()
        {
            var json = await this.GetMessage(ClientHelper.swapiUrl).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SwapiData>(json);
        }
    }
}
