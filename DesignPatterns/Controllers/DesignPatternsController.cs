using Core.Creational.FactoryMethod.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Core.Enumerations.Enumerations;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class DesignPatternsController : ControllerBase
	{
		private readonly ITransportFactory _transportFactory;

		public DesignPatternsController(ITransportFactory transportFactory)
		{
			_transportFactory = transportFactory;
		}

		[HttpGet("/factory")]
		public IActionResult Factory( Transport transportType )
		{
			try
			{
				var transport = _transportFactory.CreateInstance(transportType);

				return Ok(transport.Build());
			}
			catch (ArgumentException ex) 
			{
				return StatusCode(422, new { Error = ex.Message });
			}
			catch (Exception ex)
			{
				return StatusCode(500, new { Error = ex.Message });
			}
		}	
	}
}
