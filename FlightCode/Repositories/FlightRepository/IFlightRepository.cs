using FlightCode.Models;

namespace FlightCode.Repositories.FlightRepository;

public interface IFlightRepository
{

    public IEnumerable<Flight> GetAll();
    public Flight FindOne(int Id);
    public Flight CreateOne();
    public Flight DeleteOne();

    public Flight UpdateOne();


}
