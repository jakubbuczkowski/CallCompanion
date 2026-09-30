using Microsoft.EntityFrameworkCore;

namespace CallCompanion.Data
{
    public class CallCompanionDbContext : DbContext
    {
        public CallCompanionDbContext(DbContextOptions<CallCompanionDbContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
