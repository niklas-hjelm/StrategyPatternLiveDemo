namespace StrategyPatternLiveDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("add")]
        public IActionResult GetSum(double a, double b)
        {
            _calculator.SetStrategy(new CalculateAddition());
            return Ok(_calculator.Calculate(a,b));
        }

        [HttpGet("sub")]
        public IActionResult GetDiff(double a, double b)
        {
            _calculator.SetStrategy(new CalculateSubtraction());
            return Ok(_calculator.Calculate(a, b));
        }

        [HttpGet("multi")]
        public IActionResult GetProd(double a, double b)
        {
            _calculator.SetStrategy(new CalculateMultiplication());
            return Ok(_calculator.Calculate(a, b));
        }

        [HttpGet("div")]
        public IActionResult GetQuote(double a, double b)
        {
            if (b==0)
                return BadRequest("Cannot divide by Zero, you moron!");

            _calculator.SetStrategy(new CalculateDivision());
            return Ok(_calculator.Calculate(a, b));
        }
    }
}
