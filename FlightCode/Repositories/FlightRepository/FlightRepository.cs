using FlightCode.Data;
using FlightCode.Models;

namespace FlightCode.Repositories.FlightRepository
{
    public class FlightRepository : IFlightRepository
    {
        private readonly AppDbContext _context;

        public FlightRepository(AppDbContext context )
        {
            _context = context;
        }

        public Flight CreateOne()
        {
            throw new NotImplementedException();
        }

        public Flight DeleteOne()
        {
            throw new NotImplementedException();
        }

        public Flight FindOne(int Id)
        {
            var flights = GetAll();
            var findFlight = flights.Where(f => f.Id == Id).FirstOrDefault();
            return findFlight;
        }

        public IEnumerable<Flight> GetAll() 
        {
            var flights = _context.Flights;
            return flights;
        }

        public Flight UpdateOne()
        {
            throw new NotImplementedException();
        }
    }
}
