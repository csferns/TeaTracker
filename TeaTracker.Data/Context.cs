using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeaTracker.Data.Entities;

namespace TeaTracker.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
             
        }

        public DbSet<History> History { get; set; }
    }
}
