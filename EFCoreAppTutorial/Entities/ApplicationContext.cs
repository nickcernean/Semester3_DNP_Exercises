using Microsoft.EntityFrameworkCore;

namespace EFCoreAppTutorial.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Student>().Property(s => s.StudentId).HasColumnName("StudentId");
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.Age).IsRequired(false);
            modelBuilder.Entity<Student>().Property(s => s.IsRegularStudent).HasDefaultValue(true);
        }
    }
}