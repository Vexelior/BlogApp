using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Repository
{
    public interface IBlogPostsRepository
    {
        Task<BlogPost> GetByIdAsync(int id);
        Task<IEnumerable<BlogPost>> GetAllAsync();
        Task AddAsync(BlogPost blogPost);
        Task UpdateAsync(BlogPost blogPost);
        Task DeleteAsync(BlogPost blogPost);
    }
}