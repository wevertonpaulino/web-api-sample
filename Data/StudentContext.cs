using Microsoft.EntityFrameworkCore;
using WebApiStudent.Models;

namespace WebApiStudent.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }
    }
}