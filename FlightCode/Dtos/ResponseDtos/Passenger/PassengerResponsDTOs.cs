using System.Net;

namespace FlightCode.Dtos.ResponseDtos.PassengerRespons
{
    public class PassengerResponseDTOs
    {
        public bool status { get; set; }

        public string message { get; set; }

        public object data { get; set; }
        public HttpStatusCode code { get; set; }

    }
}
