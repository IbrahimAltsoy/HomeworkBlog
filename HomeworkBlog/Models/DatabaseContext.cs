using Microsoft.EntityFrameworkCore;

namespace HomeworkBlog.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// OnConfiguring 
            optionsBuilder.UseSqlServer("Server=DESKTOP-O97PCTN\\SQLEXPRESS;Database=HomeworkBlog;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id= 1,
                    CreatedTime= DateTime.Now,
                    Email="a@gmail.com",
                    IsActive=true,
                    IsAdmin=true,
                    Name="Admin",
                    Surname="admin",
                    Password="123",
                }
               );
            base.OnModelCreating(modelBuilder);
        }
    }
}
