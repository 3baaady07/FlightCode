using System.ComponentModel.DataAnnotations;

namespace FlightCode.Dtos.RequestDtos.Passenger
{
    public class StorePassengerRequest
    {
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Email { get; set; }

    }
}
