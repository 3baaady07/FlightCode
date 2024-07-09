using AutoMapper;
using FlightCode.Dtos;
using FlightCode.Models;
using FlightCode.Repositories.BookingRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingController(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }

        // get bookings
        [HttpGet]
        [Route("GetBookings")]
        public async Task<ActionResult<IEnumerable<GetBookingDTO>>> GetBookings()
        {
            var bookings = await _bookingRepository.GetBookingsAsync();
            var mapper = _mapper.Map<IEnumerable<GetBookingDTO>>(bookings);
            return Ok(mapper);
        }
        [HttpGet]
        [Route("GetBookingById/{id}")]
        public async Task<ActionResult<GetBookingDTO>> GetBookingById(int id)
        {
            if (!await _bookingRepository.CheckBookingAsync(id))
            {
                return NotFound();
            }
            var booking = await _bookingRepository.GetBookingByIdAsync(id);
            var mapper = _mapper.Map<GetBookingDTO>(booking);
            return Ok(mapper);
        }
        [HttpPost]
        [Route("AddBooking")]
        public async Task<ActionResult<PostBookingDTO>> AddBooking(PostBookingDTO booking)
        {
            var mapper = _mapper.Map<Booking>(booking);
            await _bookingRepository.AddBookingAsync(mapper);
            return RedirectToAction("GetBookings");
        }
        [HttpPut]
        [Route("UpdateBooking/{id}")]
        public async Task<ActionResult<PostBookingDTO>> UpdateBooking(PostBookingDTO booking, int id)
        {
            if (!await _bookingRepository.CheckBookingAsync(id))
            {
                return NotFound();
            }
            var mapper = _mapper.Map<Booking>(booking);
            await _bookingRepository.UpdateBookingAsync(mapper, id);
            return Ok(booking);
        }
        [HttpDelete]
        [Route("DeleteBooking/{id}")]
        public async Task<ActionResult> DeleteBooking(int id)
        {
            if (!await _bookingRepository.CheckBookingAsync(id))
            {
                return NotFound();
            }
            await _bookingRepository.DeleteBookingAsync(id);
            return Ok();
        }

    }
}
