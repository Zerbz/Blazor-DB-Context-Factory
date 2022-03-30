using Microsoft.EntityFrameworkCore;

namespace Blazor_DbContextFactory.Data
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options) { }
        
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().ToTable("WeatherForecast");
        }
    }
}


