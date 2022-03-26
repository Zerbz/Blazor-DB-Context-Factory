using Microsoft.EntityFrameworkCore;

namespace Blazor_DbContextFactory.Data
{
    public class WeatherForecastService
    {
        private readonly ExampleContext _exampleContext;

        public WeatherForecastService(ExampleContext exampleContext)
        {
            _exampleContext = exampleContext;
        }

        public async Task<List<WeatherForecast>> GetForecastAsync()
        {
            return await _exampleContext.WeatherForecasts.ToListAsync();
        }

        public async Task<bool> InsertForecastAsync(WeatherForecast forecast)
        {
            await _exampleContext.WeatherForecasts.AddAsync(forecast);
            await _exampleContext.SaveChangesAsync();
            return true;
        }
    }
}