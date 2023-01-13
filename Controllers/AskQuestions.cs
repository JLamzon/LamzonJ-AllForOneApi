using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_AskQuestionsEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("AskQuestions/{name}/{time}")]

    public string AskQuestions(string name, string time)
    {
        return $"Your name is {name} and today you woke up at {time}.";
    }
}