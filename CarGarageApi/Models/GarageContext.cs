using Microsoft.EntityFrameworkCore;

namespace CarGarageApi.Models
{
    public class GarageContext : DbContext
    {
        public GarageContext(DbContextOptions<GarageContext> options) : base(options)
        {
        }

        public DbSet<Garage> Garages { get; set; } = null!;
    }
}
