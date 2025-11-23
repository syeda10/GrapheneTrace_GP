using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Models;  

namespace GrapheneTrace_GP.Data 
{
    /// <summary>
    /// EF Core database context: configure DbSets for your tables.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Map to table 'users' in GrapheneTraceDB
        public DbSet<UserAccount> Users => Set<UserAccount>();
    }
}

