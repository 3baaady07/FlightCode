using AutoMapper;
using FlightCode.Models;
namespace WebApplicationAPI.Profiles
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Flight, FlightReadDto>();
        }
    }
}
