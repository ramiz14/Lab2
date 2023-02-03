using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        
        }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<Pricing> pricings { get; set; }
        public DbSet<Trainers> trainers { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<Features> features { get; set; }
        public DbSet<Home> homes { get; set; }
    }
}
