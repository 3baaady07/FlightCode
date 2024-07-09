using AutoMapper;
using FlightCode.Dtos;
using FlightCode.Models;

namespace FlightCode.Mapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            //CreateMap<Models.Passenger, Dtos.PassengerDTO>();
            //CreateMap<Dtos.PassengerDTO, Models.Passenger>();
            //CreateMap<Models.Booking, Dtos.BookingDTO>();
            //CreateMap<Dtos.BookingDTO, Models.Booking>();
            //CreateMap<Models.Flight, Dtos.FlightDTO>();
            //CreateMap<Dtos.FlightDTO, Models.Flight>();

            CreateMap<PostFlightDTO, Flight>();
            CreateMap<Flight, PostFlightDTO>();
            CreateMap<Flight , GetFlightDTO>();
            CreateMap<GetFlightDTO, Flight>();
            CreateMap<Booking, GetBookingDTO>();
            CreateMap<GetBookingDTO, Booking>();
            CreateMap<GetPassengerDTO, Passenger>();
            CreateMap<Passenger, GetPassengerDTO>();
            CreateMap<PostPassengerDTO, Passenger>();
            CreateMap<Passenger, PostPassengerDTO>();
            CreateMap<PostBookingDTO, Booking>();
            CreateMap<Booking, PostBookingDTO>();
        }

    }
}
