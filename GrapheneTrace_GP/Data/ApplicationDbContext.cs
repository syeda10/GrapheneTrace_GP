using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Clinicians> Clinicians { get; set; }
    }
}

