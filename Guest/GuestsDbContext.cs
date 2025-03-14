using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Guest
{
    public class GuestsDbContext: DbContext
   {
        public GuestsDbContext(DbContextOptions<GuestsDbContext> options)
            : base(options)
        {

        }

        public DbSet<Guests> Guest { get; set; }
    }
}
