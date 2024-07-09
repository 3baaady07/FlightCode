using System.ComponentModel.DataAnnotations;

namespace FlightCode.Models;

public class Booking
{
    [Key]
    public int Id { get; set; }
    public int PassengerId { get; set; }
    public Passenger? Passenger { get; set; }
    public int FlightId { get; set; }
    public Flight? Flight { get; set; }
}
