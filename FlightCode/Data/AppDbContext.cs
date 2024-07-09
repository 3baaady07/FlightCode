﻿using FlightCode.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightCode.Data;

public class AppDbContext : DbContext
{
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Flight>().HasData(new Flight
        {
            Id = 1,
            Arrival = new DateTime(2022, 1, 1, 12, 0, 0),
            From = "Riyadh",
            To = "Jeddah",
            Departuer= new DateTime(2022, 1, 1, 10, 0, 0)
        });

        modelBuilder.Entity<Passenger>().HasData(new Passenger
        {
            Id = 1,
            FullName = "Ahmed",
            Email = "ooo@oo.com",
            PhoneNumber = "123456789"
        });

        modelBuilder.Entity<Booking>().HasData(new Booking
        {
            Id = "1",
            FlightId = 1,
            PassengerId = 1
        });
    }
}