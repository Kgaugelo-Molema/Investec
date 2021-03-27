﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        /// <summary>
        /// Get Operation
        /// </summary>
        /// <remarks>
        /// Sample value of message
        /// 
        ///     POST /Todo
        ///     {
        ///        "variable1": "Hi",
        ///        "variable2": "Sukhpinder"
        ///     }
        ///     
        /// </remarks>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await this.GetMessage(ClientHelper.chuckUrl).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<string>>(result);
        }
    }
}
