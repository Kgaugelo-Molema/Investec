﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Newtonsoft.Json;

namespace Movies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        [HttpGet]
        public async Task<SwapiData> Get()
        {
            var json = await this.GetMessage(ClientHelper.swapiUrl).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SwapiData>(json);
        }
    }
}
