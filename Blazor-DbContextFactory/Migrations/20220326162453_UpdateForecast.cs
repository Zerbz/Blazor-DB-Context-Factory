using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_DbContextFactory.Migrations
{
    public partial class UpdateForecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TemperatureF",
                table: "WeatherForecast",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemperatureF",
                table: "WeatherForecast");
        }
    }
}
