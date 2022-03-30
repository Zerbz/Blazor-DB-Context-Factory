using System.ComponentModel.DataAnnotations;

namespace Blazor_DbContextFactory.Data
{
    public class WeatherForecast
    {
        [Key]
        public int ForecastId { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }
    }
}

