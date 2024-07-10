using FlightCode.Data;
using FlightCode.Dtos.RequestDtos.Passenger;
using FlightCode.Dtos.ResponseDtos.PassengerRespons;
using FlightCode.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightCode.Repositories.PassengerRepository
{
    public class PassengerRepository :IPassengerRepository
    {
        private AppDbContext _context;

        public PassengerRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<PassengerResponseDTOs> store(StorePassengerRequest storePassengerRequest)
        {

            var newPassenger = new Passenger()
            {
                Id = 1,
                FullName = storePassengerRequest.FullName,
                PhoneNumber = storePassengerRequest.PhoneNumber,
                Email = storePassengerRequest.Email,
                
            };
            await _context.Passengers.AddAsync(newPassenger);
            await _context.SaveChangesAsync();

            return new PassengerResponseDTOs() { data = newPassenger, message = "Success", status = true, code = System.Net.HttpStatusCode.OK };

        }
        public async Task<PassengerResponseDTOs> getById(string id)
        {
            var city = await _context.Passengers.FindAsync(id);
            if (city == null)
            {
                return new PassengerResponseDTOs() { data = null, message = "Data not found", status = false, code = System.Net.HttpStatusCode.NotFound };
            }
            return new PassengerResponseDTOs() { data = city, message = "Success", status = true, code = System.Net.HttpStatusCode.OK };
        }

        public async Task<PassengerResponseDTOs> getAll()
        {
            var passengers = await _context.Passengers.ToListAsync();

            return new PassengerResponseDTOs() { data = passengers, message = "Success", status = true, code = System.Net.HttpStatusCode.OK };
        }

        public async Task<PassengerResponseDTOs> update(string id, UpdatePassengerRequest updatePassengerRequest)
        {
            var passenger = await _context.Passengers.FindAsync(id);
            if (passenger == null)
            {
                return new PassengerResponseDTOs() { message = "Passenger not found", status = false, code = System.Net.HttpStatusCode.NotFound };
            }

            passenger.FullName = updatePassengerRequest.FullName;
            passenger.PhoneNumber = updatePassengerRequest.PhoneNumber;
            passenger.Email = updatePassengerRequest.Email;
           

            await _context.SaveChangesAsync();
            return new PassengerResponseDTOs() { data = passenger, message = "Success", status = true, code = System.Net.HttpStatusCode.OK };

        }

        public async Task<PassengerResponseDTOs> delete(string id)
        {
            var passenger = await _context.Passengers.FindAsync(id);
            if (passenger == null)
            {
                return new PassengerResponseDTOs() { message = "passenger not found", status = false, code = System.Net.HttpStatusCode.NotFound };
            }
            _context.Entry(passenger).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return new PassengerResponseDTOs() { message = "passenger deleted Successfully", status = true, code = System.Net.HttpStatusCode.OK };

        }





    }
}
