using HotelManagement.Payment;
using Microsoft.EntityFrameworkCore;


namespace HotelManagement.Controllers
{
    public class PaymentsDbContext : DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext>pickups)
            : base(pickups)
        {

        }

       public DbSet<Payments> Payment { get; set; }


    }
}
