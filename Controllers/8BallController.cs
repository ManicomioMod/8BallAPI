using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _8BallAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class BallController : ControllerBase
    {
        [HttpGet]
    [Route("Magic/{userQuestion}")]

    public string Magic8(string userQuestion)
    {
        Random random = new Random();
        string[] answer = {"Yes", "No", "Maybe", "It is certain", "Ask again later",
        "Definitely", "Most likely", "Definately Not", "Better to not tell you now", "Its not looking to good "};

        int index = random.Next(answer.Length);
        return answer[index];
    }
    }
