using FlightCode.Models;

namespace FlightCode.Repositories.BookingRepository
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetBookingsAsync();

        Task<Booking> GetBookingByIdAsync(int id);

        Task AddBookingAsync(Booking booking);

        Task UpdateBookingAsync(Booking booking, int id);
        Task DeleteBookingAsync(int id);

        Task<bool> CheckBookingAsync(int id);
    }
}
