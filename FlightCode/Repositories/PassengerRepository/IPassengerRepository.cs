using FlightCode.Dtos.RequestDtos.Passenger;
using FlightCode.Dtos.ResponseDtos.PassengerRespons;

namespace FlightCode.Repositories.PassengerRepository;

public interface IPassengerRepository
{
    Task<PassengerResponseDTOs> store(StorePassengerRequest storePassengerRequest);
    Task<PassengerResponseDTOs> getById(string id);
    Task<PassengerResponseDTOs> getAll();
    Task<PassengerResponseDTOs> update(string id, UpdatePassengerRequest updatePassengerRequest);
    Task<PassengerResponseDTOs> delete(string id);
}
