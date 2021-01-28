using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{letters}")]
        public string MumblingLetters(string letters)
        {
            var answer = "";
            for (var i = 0; i < letters.Length; i++)
            {
                var Upper = letters[i].ToString().ToUpper();
                var lower = letters[i].ToString().ToLower();

                answer += Upper;
                for (var j = 0; j < i; j++)
                {
                    answer += lower;
                }

                answer += "-";
            }
            return answer.Trim('-');
        }
    }
}