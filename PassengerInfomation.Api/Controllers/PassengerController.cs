using Microsoft.AspNetCore.Mvc;
using PassengerInfomation.Api.DataEntities;
using System;

namespace PassengerInfomation.Api.Controllers
{
	public class PassengerController : ControllerBase
	{
		[HttpGet("/resource")]
		public IActionResult GetResource(Guid passenger)
		{
			return Ok(new Passenger() { Surname = "Builder" });
		}
	}
}
