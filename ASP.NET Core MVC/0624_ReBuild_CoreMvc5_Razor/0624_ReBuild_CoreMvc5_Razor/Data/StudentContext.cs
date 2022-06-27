using _0624_ReBuild_CoreMvc5_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace _0624_ReBuild_CoreMvc5_Razor.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Joe", Chinese = 88, English = 95, Math = 71 },
                new Student { Id = 12, Name = "Aoe", Chinese = 88, English = 95, Math = 71 },
                new Student { Id = 11, Name = "Eoe", Chinese = 88, English = 95, Math = 71 },
                new Student { Id = 14, Name = "Voe", Chinese = 88, English = 95, Math = 71 },
                new Student { Id = 16, Name = "Doe", Chinese = 88, English = 95, Math = 71 }
               );
        }
    }
}
