using System;

namespace PassengerInfomation.Api.DataEntities
{
	public class Person
	{
		public string Surname { get; set; }
		public string FirstName { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Nationality { get; set; }
	}
}
