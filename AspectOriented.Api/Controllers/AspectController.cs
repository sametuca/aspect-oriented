using AspectOriented.Core;
using Microsoft.AspNetCore.Mvc;

namespace AspectOriented.Api.Controllers
{
    [ApiController]
    [Route("aspect")]
    public class AspectController : ControllerBase
    {
        ICalculator _calculator;

        public AspectController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("Sum")]
        public int Sum(int a,int b)
        {
            return _calculator.Add(a,b);
        }

        [HttpPost("Multiply")]
        public int Multiply(int a, int b)
        {
            return _calculator.Multiply(a, b);
        }
    }
}
