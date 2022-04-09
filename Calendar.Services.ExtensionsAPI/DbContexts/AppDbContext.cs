using Calendar.Services.ExtensionsAPI.Models;

namespace Calendar.Services.ExtensionsAPI.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
