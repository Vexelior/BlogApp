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
            List<Post> posts = new();

            for (int i = 1; i <= 100; i++)
            {
                posts.Add(new Post
                {
                    PostId = i,
                    Title = $"Post {i}",
                    Content = $"Content for post {i}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }

            foreach (Post post in posts)
            {
                modelBuilder.Entity<Post>().HasData(post);
            }
        }
    }
}

