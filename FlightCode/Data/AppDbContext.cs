using FlightCode.Models;
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

        //modelBuilder.Entity<Booking>()
        //    .HasKey(e => new { e.FlightId, e.PassengerId });
    }
}