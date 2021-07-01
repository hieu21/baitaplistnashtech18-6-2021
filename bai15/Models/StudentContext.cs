using System;
using Microsoft.EntityFrameworkCore;
namespace bai15.Models
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions options) : base(options) { }
        
        //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseSqlServer(connectionString);
        // }
        // private const string connectionString = "User ID=yourusername;password=Password;server=your server;Database=Student;";
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
       
    }
}