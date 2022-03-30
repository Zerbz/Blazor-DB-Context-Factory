using Microsoft.EntityFrameworkCore;

namespace Blazor_DbContextFactory.Data
{
    public class WeatherForecastService
    {
        private readonly IDbContextFactory<ExampleContext> _dbContextFactory;

        public WeatherForecastService(IDbContextFactory<ExampleContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<WeatherForecast>> GetForecastAsync()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.WeatherForecasts.ToListAsync();
        }

        public async Task<bool> InsertForecastAsync(WeatherForecast forecast)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.WeatherForecasts.AddAsync(forecast);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteForecastAsync(WeatherForecast forecast)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            dbContext.Remove(forecast);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}

