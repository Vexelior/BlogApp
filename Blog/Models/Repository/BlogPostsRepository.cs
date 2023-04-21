using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Repository
{
    public class BlogPostsRepository : IBlogPostsRepository
    {
        private readonly ApplicationDbContext _dbContext;
    
        public BlogPostsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<BlogPost> GetByIdAsync(int id)
        {
            return await _dbContext.BlogPost.FindAsync(id);
        }
        
        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await _dbContext.BlogPost.ToListAsync();
        }
        
        public async Task AddAsync(BlogPost post)
        {
            _dbContext.BlogPost.Add(post);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(BlogPost post)
        {
            _dbContext.Entry(post).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(BlogPost post)
        {
            _dbContext.BlogPost.Remove(post);
            await _dbContext.SaveChangesAsync();
        }
    }
}