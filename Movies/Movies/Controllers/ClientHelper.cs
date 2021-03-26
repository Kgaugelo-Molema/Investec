using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public static class ClientHelper
    {
        public const string chuckUrl = "https://api.chucknorris.io/jokes/categories";

        public static async Task<string> GetMessage(this ControllerBase controllerBase, string url)
        {
            var client = new HttpClient();
            var stringTask = client.GetStringAsync(url);

            return await stringTask;
        }
    }
}
