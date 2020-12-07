using Microsoft.AspNetCore.Identity;
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
            modelBuilder.Entity<QuizQuestion>()
                .HasKey(q => new { q.QuizId, q.QuestionId });

            modelBuilder.Entity<UserScore>()
                .HasKey(q => new { q.QuizId, q.UserId });

            modelBuilder.Entity<UserAnswer>()
                .HasKey(q => new { q.QuizId, q.UserId, q.QuestionId});


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserScore> UserScores { get; set; }

        public DbSet<QuizQuestion> QuizQuestions { get; set; }

        public DbSet<Quiz> Quiz { get; set; }

        public DbSet<UserAnswer> UserAnswer { get; set; }
    }
}
