using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adapters.SQL
{
    public class HotelDbContext(DbContextOptions<HotelDbContext> options) : DbContext(options)
    {
        public DbSet<Guest> Guests { get; set; }
    }

}
