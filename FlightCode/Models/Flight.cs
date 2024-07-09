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
    public DateTime Departuer { get; set; }
    [Required]
    public DateTime Arrival { get; set; }

    public IEnumerable<Booking>? Bookings { get; set; }
}

public class FlightReadDto
{
    public int Id { get; set; }
    [Required]
    public string? From { get; set; }
    [Required]
    public string? To { get; set; }
    [Required]
    public DateTime Departuer { get; set; }
    [Required]
    public DateTime Arrival { get; set; }

}
