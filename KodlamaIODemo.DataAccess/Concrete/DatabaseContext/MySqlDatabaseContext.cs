using KodlamaIODemo.DataAccess.Abstract.DatabaseContext;
using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Concrete.DatabaseContext
{
    public class MySqlDatabaseContext : DbContext, IMySqlDatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Konfigüreasyon yapılmamış ise diyoruz.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Port=****;Database=KodlamIODemoApplication;Uid=root;Pwd=*****;Persist Security Info=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseCategory>().HasKey(x => new { x.Id, x.CategoryId, x.CourseId });
            modelBuilder.Entity<CourseInstructor>().HasKey(x => new { x.Id, x.InstructorId, x.CourseId });
            modelBuilder.Entity<CourseStudent>().HasKey(x => new { x.Id, x.StudentId, x.CourseId });
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<CourseInstructor> InstructorCourse { get; set; }
        public DbSet<Entities.Models.Student> Student { get; set; }
        public DbSet<CourseStudent> StudentCourse { get; set; }
    }
}
