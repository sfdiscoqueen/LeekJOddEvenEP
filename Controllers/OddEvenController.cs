// Jasmine Leek
// 26oct2022
// Odd or Even - Endpoints
// this is a webapi that determines if a number is odd or even through url input; took input from Jeremy re negative numbers, added Math.Abs 
// peer review: Jeremy Lapham: Works great gives me the right answers. But with negative odd numbers nothing shows up 


using Microsoft.AspNetCore.Mvc;

namespace LeekJOddEvenEP.Controllers;

[ApiController]
[Route("[controller]")]
public class OddEvenController : ControllerBase
{
    [HttpGet]
    [Route("Determine/{number1}")]

    public string NumberCalc(string number1)
    {
        bool isNum1;
        int validNum1 = 0;
        isNum1 = Int32.TryParse(number1, out validNum1);

        if (isNum1 == true)
        {
            int i = (Math.Abs(validNum1) % 2);

            if (i == 0)
            {
                return $"{number1} is an even number.";
            }
            else if (i == 1)
            {
                return $"{number1} is an odd number.";
            }
        }
        return "";

    }
}