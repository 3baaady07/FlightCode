using FlightCode.Data;
using FlightCode.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightCode.Repositories.BookingRepository
{
    public class BookingRepository : IBookingRepository
    {

       private readonly AppDbContext _appDbContext;

        public BookingRepository(AppDbContext appDbContext)
        {
             _appDbContext = appDbContext;
        }

        // get bookings
        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _appDbContext.Bookings.ToListAsync();
        }

        // get booking by id

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _appDbContext.Bookings.FindAsync(id);
        }

        // add booking
        public async Task AddBookingAsync(Booking booking)
        {
            _appDbContext.Bookings.Add(booking);
            await _appDbContext.SaveChangesAsync();
        }

        // update booking
        public async Task UpdateBookingAsync(Booking booking, int id)
        {
            var bookingToUpdate = await _appDbContext.Bookings.FindAsync(id);
            bookingToUpdate.PassengerId = booking.PassengerId;
            bookingToUpdate.FlightId = booking.FlightId;
            await _appDbContext.SaveChangesAsync();
        }

        // delete booking
        public async Task DeleteBookingAsync(int id)
        {
            var bookingToDelete = await _appDbContext.Bookings.FindAsync(id);
            _appDbContext.Bookings.Remove(bookingToDelete);
            await _appDbContext.SaveChangesAsync();
        }

        // check booking
        public async Task<bool> CheckBookingAsync(int id)
        {
            return await _appDbContext.Bookings.AnyAsync(b => b.Id == id);
        }
    }
}
