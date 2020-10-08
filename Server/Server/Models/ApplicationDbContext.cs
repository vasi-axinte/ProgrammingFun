using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserScore> Scores { get; set; }
    }
}
