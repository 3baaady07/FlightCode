namespace FlightCode.Models;

public class Passenger
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public IEnumerable<Flight>? Flights { get; set; }
}
