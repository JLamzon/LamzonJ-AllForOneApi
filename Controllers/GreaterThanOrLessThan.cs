using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_GreaterThanOrLessThanEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    [HttpGet]
    [Route("GreaterThanLessThan/{numberOne}/{numberTwo}")]

    public string GreaterOrLessThan(string numberOne, string numberTwo)
    {
        int validNumOne = 0;
        int validNumTwo = 0;
        bool numbOne = true;
        bool numbTwo = true;

        numbOne = Int32.TryParse(numberOne, out validNumOne);
        numbTwo = Int32.TryParse(numberTwo, out validNumTwo);

        if (numbOne == true && numbTwo == true)
        {
            if (validNumOne < validNumTwo)
            {
                return $"{validNumOne} is less than {validNumTwo}";
            }
            else if (validNumOne > validNumTwo)
            {
                return $"{validNumOne} is more than {validNumTwo}";
            }
            else
            {
                return $"{validNumOne} is equal to {validNumTwo}";
            }
        }
        else
        {
            return "Please enter correct format";
        }
    }
}
