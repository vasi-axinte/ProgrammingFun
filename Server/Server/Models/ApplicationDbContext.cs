using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizQuestions>()
                .HasKey(q => new { q.QuizId, q.QuestionId });
             base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserScore> Scores { get; set; }

        public DbSet<QuizQuestions> QuizQuestions { get; set; }

        public DbSet<Quiz> Quiz { get; set; }
    }
}
