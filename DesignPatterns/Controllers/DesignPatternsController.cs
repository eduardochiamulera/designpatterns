using Core.Creational.AbstractFactory.Interfaces;
using Core.Creational.FactoryMethod.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Core.Enumerations.Enumerations;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class DesignPatternsController : ControllerBase
	{
		// Factory Method
		private readonly ITransportFactory _transportFactory;

		//Abstract Factory
		private readonly IFurniteFactory _furniteFactory;

		public DesignPatternsController(ITransportFactory transportFactory, IFurniteFactory furniteFactory)
		{
			_transportFactory = transportFactory;
			_furniteFactory = furniteFactory;
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

		[HttpGet("/abstract-factory")]
		public IActionResult AbstractFactory(Forniture forniture, FornitureType fornitureType)
		{
			try
			{
				string result = "";

				var factory = _furniteFactory.CreateFactory(forniture);

				if(fornitureType == FornitureType.Chair)
				{
					var chair = factory.CreateChair();
					result = chair.Print();
				}
				else
				{
					var sofa = factory.CreateSofa();
					result = sofa.Print();
				}

				return Ok(result);
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
