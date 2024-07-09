using FlightCode.Models;

namespace FlightCode.Dtos
{
    public class GetBookingDTO
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }

    }
}
