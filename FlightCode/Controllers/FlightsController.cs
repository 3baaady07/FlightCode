using AutoMapper;
using FlightCode.Models;
using FlightCode.Repositories.FlightRepository;
using Microsoft.AspNetCore.Mvc;

namespace FlightCode.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{

    private readonly IFlightRepository _flightRepository;
    private readonly IMapper _mapper;

    public FlightsController(IFlightRepository flightRepositor,IMapper mapper)
    {
    _flightRepository = flightRepositor;
        _mapper = mapper;
    }

    [HttpGet]

    public ActionResult<IEnumerable<FlightReadDto>> GetAll()
    {
        var flights = _flightRepository.GetAll();
        var ReadFlights = _mapper.Map<IEnumerable<FlightReadDto>>(flights);
        return Ok(ReadFlights);
    }
    [HttpGet("{Id}")]

    public ActionResult<FlightReadDto> FindOne (int Id)
    {
        var findFlight = _flightRepository.FindOne(Id);
        var ReadFlight = _mapper.Map<FlightReadDto>(findFlight);
        return Ok(ReadFlight);
    }


    
}
