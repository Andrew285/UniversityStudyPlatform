using Microsoft.EntityFrameworkCore;
using UniversityStudyPlatform.Models;

namespace UniversityStudyPlatform.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<AccountBook> AccountBooks { get; set; }
        public DbSet<StudentPerfomance> StudentPerfomances { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}