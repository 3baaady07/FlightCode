﻿select Flights.Id ,Passengers.Id,Passengers.FullName from Flights join Passengers on Flights.Id=Passengers.FlightId where Flights.Id=1