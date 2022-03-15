using Microsoft.EntityFrameworkCore;

namespace Hamazon_DataAccess.Data
{
    public class HamazonDbContext : DbContext
    {
        public HamazonDbContext(DbContextOptions<HamazonDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
