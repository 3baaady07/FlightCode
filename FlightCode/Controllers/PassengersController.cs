﻿using AutoMapper;
using FlightCode.Dtos;
using FlightCode.Models;
using FlightCode.Repositories.PassengerRepository;
using Microsoft.AspNetCore.Mvc;

namespace FlightCode.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PassengersController : ControllerBase
{
    private readonly IPassengerRepository _passengerRepository;
    private readonly IMapper _mapper;

    public PassengersController(IPassengerRepository passengerRepository, IMapper mapper)
    {
        _passengerRepository = passengerRepository;
        _mapper = mapper;
    }

    // get passengers
    [HttpGet]
    [Route("GetPassengers")]
    public async Task<ActionResult<IEnumerable<GetPassengerDTO>>> GetPassengers()
    {
        var getALlPasengers= await _passengerRepository.GetPassengersAsync();
        var mapper = _mapper.Map<IEnumerable<GetPassengerDTO>>(getALlPasengers);
        return Ok(mapper);
    }
    [HttpGet]
    [Route("GetPassengerById/{id}")]
    public async Task<ActionResult<GetPassengerDTO>> GetPassengerById(int id)
    {
        if (!await _passengerRepository.CheckPassengerAsync(id))
        {
            return NotFound();
        }
        var passenger = await _passengerRepository.GetPassengerByIdAsync(id);
        var mapper = _mapper.Map<GetPassengerDTO>(passenger);
        return mapper;
    }
    [HttpPost]
    [Route("AddPassenger/{FlightId}")]
    public async Task<ActionResult<PostPassengerDTO>> AddPassenger(PostPassengerDTO passenger ,int FlightId)
    {
        var mapper = _mapper.Map<Passenger>(passenger);
        await _passengerRepository.AddPassengerAsync(mapper, FlightId);
        return Ok();
    }

    [HttpPut]
    [Route("UpdatePassenger/{id}")]
    public async Task<ActionResult<PostPassengerDTO>> UpdatePassenger(PostPassengerDTO passenger, int id)
    {
        if (!await _passengerRepository.CheckPassengerAsync(id))
        {
            return NotFound();
        }
        var mapper = _mapper.Map<Passenger>(passenger);
        await _passengerRepository.UpdatePassengerAsync(mapper, id);
        return Ok();
    }
    [HttpDelete]
    [Route("DeletePassenger/{id}")]
    public async Task<ActionResult> DeletePassenger(int id)
    {
        if (!await _passengerRepository.CheckPassengerAsync(id))
        {
            return NotFound();
        }
        await _passengerRepository.DeletePassengerAsync(id);
        return Ok();
    }
}
