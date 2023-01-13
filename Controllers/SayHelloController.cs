using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_SayHelloEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string Hello(string name)
    {
        return $"Hello {name}! Have a good day!";
    }
}
