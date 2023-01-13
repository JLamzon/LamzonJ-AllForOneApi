using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_ReverseIt.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("Reverse/{userPick}")]

    public string Reverse(string userPick)
    {
        char[] myString = userPick.ToCharArray();
        Array.Reverse(myString);
        string reversed = new string (myString);

        return ($"You entered:{userPick}  |  Reversed is:{reversed}");
    }
}
