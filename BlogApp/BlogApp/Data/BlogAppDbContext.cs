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
            List<Post> posts = new()
            {
                new Post { PostId = 1, Title = "First Post", Content = "This is my first post.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Post { PostId = 2, Title = "Second Post", Content = "This is my second post.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Post { PostId = 3, Title = "Third Post", Content = "This is my third post.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Post { PostId = 4, Title = "Fourth Post", Content = "This is my fourth post.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Post { PostId = 5, Title = "Fifth Post", Content = "This is my fifth post.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            };

            foreach (Post post in posts)
            {
                modelBuilder.Entity<Post>().HasData(post);
            }
        }
    }
}
