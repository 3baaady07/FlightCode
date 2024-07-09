using System.ComponentModel.DataAnnotations;

namespace FlightCode.Models;

public class Flight
{
    public int Id { get; set; }
    [Required]
    public string? From { get; set; }
    [Required]
    public string? To { get; set; }
    [Required]
    public string Departuer { get; set; }
    [Required]
    public string Arrival { get; set; }

    public IEnumerable<Booking>? Bookings { get; set; }
}
