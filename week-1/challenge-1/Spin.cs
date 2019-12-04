using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Vitality.Functions
{
    public static class Spin
    {
        [FunctionName("Spin")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var options = new List<string>() { "נ", "ג", "ה", "ש" };

            return new OkObjectResult(options[new Random().Next(4)]);
        }
    }
}
