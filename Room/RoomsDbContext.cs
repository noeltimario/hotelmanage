using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Room
{
    public class RoomsDbContext : DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rooms> Rooms { get; set; } // Changed to plural
    }
}
