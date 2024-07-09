namespace FlightCode.Dtos
{
    public class GetFlightDTO
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Departuer { get; set; }
        public string Arrival { get; set; }

        public List<GetBookingDTO>? Bookings { get; set; }
    }
}
