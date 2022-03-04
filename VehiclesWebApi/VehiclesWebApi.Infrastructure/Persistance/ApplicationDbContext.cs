using Microsoft.EntityFrameworkCore;
using VehiclesWebApi.Domain.Entities;

namespace VehiclesWebApi.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
