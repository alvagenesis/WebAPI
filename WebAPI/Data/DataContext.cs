using WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public IConfiguration _config {  get; set; }
        public DataContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }

        public DbSet <Item> Items {get; set; }
        public DbSet <UnitOfMeasurement> UnitOfMeasurements { get; set; }
    }
}
