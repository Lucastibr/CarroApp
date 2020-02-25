using Microsoft.EntityFrameworkCore;

namespace CarroApp.Models
{
    public class CarroAppContext : DbContext
    {
        public CarroAppContext (DbContextOptions<CarroAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarroApp.Models.Carro> Carro { get; set; }
    }
}
