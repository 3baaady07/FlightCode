using System.ComponentModel.DataAnnotations;

namespace FlightCode.Models;

public class Passenger
{
    public int Id { get; set; }
    [Required]
    public string? FullName { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }
    [Required]
    public string? Email { get; set; }
    public IEnumerable<Booking>? Bookings { get; set; }
}
