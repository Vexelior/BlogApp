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
                    Content = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.",
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

