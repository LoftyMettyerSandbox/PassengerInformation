using Microsoft.AspNetCore.Mvc;
using PassengerInfomation.Api.DataEntities;
using System;

namespace PassengerInfomation.Api.Controllers
{
	public class PassportController : ControllerBase
	{
		[HttpGet("/resource")]
		[ProducesResponseType(typeof(Passport), 200)]
		public IActionResult GetResource(Guid passenger)
		{
			return Ok(new Passport()
			{
				Type = DocumentType.Passport,
				Passenger = new Person()
				{
					Surname = "Avery",
					FirstName = "Debbie",
				},
				IssueDate = DateTime.Now
			}); ;
		}
	}
}