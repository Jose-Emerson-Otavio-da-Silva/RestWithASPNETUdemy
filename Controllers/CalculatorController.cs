using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{


		private readonly ILogger<WeatherForecastController> _logger;



		[HttpGet("sum/{firstNumber}/{secondNumber}")]
		public IActionResult Get(string firstNumber, string secondNumber)
		{
			if (IsNumber(firstNumber) && IsNumber(secondNumber))
			{
				var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
				return Ok(sum.ToString());
			}
			return BadRequest("Invalid Input");
		}

		private int ConvertToDecimal(string firstNumber)
		{
			throw new NotImplementedException();
		}

		private bool IsNumber(string firstNumber)
		{
			throw new NotImplementedException();
		}
	}
}
