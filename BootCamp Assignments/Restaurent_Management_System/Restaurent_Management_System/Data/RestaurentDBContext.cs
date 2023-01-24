using Microsoft.EntityFrameworkCore;
using Restaurent_Management_System.Models;

namespace Restaurent_Management_System.Data
{
    public class RestaurantDBContext: DbContext
    {
        public RestaurantDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BookingModel> TablBookings { get; set; }
    }
}
