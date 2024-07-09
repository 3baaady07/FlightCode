namespace FlightCode.Models;

public class Booking
{
    public int PassengerId { get; set; }
    public Passenger? Passenger { get; set; }
    public int FlightId { get; set; }
    public Flight? Flight { get; set; }
}
