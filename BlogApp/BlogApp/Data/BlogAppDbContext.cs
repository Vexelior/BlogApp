using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    internal sealed class BlogAppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlogApp;Trusted_Connection=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post post1 = new() { PostId = 1, Title = "First Post", Content = "This is my first post.", CreatedAt = new System.DateTime(2020, 1, 1), UpdatedAt = new System.DateTime(2020, 1, 1) };

            modelBuilder.Entity<Post>().HasData(post1);
        }
    }
}
