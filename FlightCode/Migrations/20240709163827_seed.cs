using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightCode.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Arrival", "Departuer", "From", "To" },
                values: new object[] { 1, new DateTime(2022, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Riyadh", "Jeddah" });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Email", "FullName", "PhoneNumber" },
                values: new object[] { 1, "ooo@oo.com", "Ahmed", "123456789" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "FlightId", "PassengerId" },
                values: new object[] { "1", 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
