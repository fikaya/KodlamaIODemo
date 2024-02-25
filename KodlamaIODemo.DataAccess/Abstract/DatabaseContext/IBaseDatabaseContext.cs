using KodlamaIODemo.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KodlamaIODemo.DataAccess.Abstract.DatabaseContext
{
    internal interface IBaseDatabaseContext
    {
        public DbSet<Entities.Models.Category> Category { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<CourseInstructor> InstructorCourse { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<CourseStudent> StudentCourse { get; set; }
    }
}
