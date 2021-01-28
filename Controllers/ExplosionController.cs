using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{numbers}")]
        public string ExplodedNumbers(string numbers)
        {
            var answer = "";
            for (var i = 0; i < numbers.Length; i++)
            {
                var num = int.Parse(numbers[i].ToString());
                for (var j = 0; j < num; j++)
                {
                    answer += numbers[i];
                }
            }
            return answer;
        }
    }
}