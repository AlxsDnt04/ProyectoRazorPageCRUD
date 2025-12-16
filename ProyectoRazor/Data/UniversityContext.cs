using Microsoft.EntityFrameworkCore;
using ProyectoRazor.Models;

namespace ProyectoRazor.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Convenciones manuales 
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollments");
        }
    }
}