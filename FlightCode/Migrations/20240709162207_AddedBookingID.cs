using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightCode.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookingID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FlightId",
                table: "Bookings",
                column: "FlightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_FlightId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bookings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                columns: new[] { "FlightId", "PassengerId" });
        }
    }
}
