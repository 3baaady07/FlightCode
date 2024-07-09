namespace FlightCode.Models;

public class Flight
{
    public int Id { get; set; }
    public string? From { get; set; }
    public string? To { get; set; }
    public DateTime Departuer { get; set; }
    public DateTime Arrival { get; set; }

    public IEnumerable<Passenger>? Passengers { get; set; }
}
