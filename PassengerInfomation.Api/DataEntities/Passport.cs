namespace PassengerInfomation.Api.DataEntities
{
	public class Passport : Document
	{
		public Person Passenger { get; set; }
	}
}
