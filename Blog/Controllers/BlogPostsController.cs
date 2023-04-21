using Blog.Models;
using Blog.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Blog.Controllers
{
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogPostsRepository _blogPostsRepository;


        public BlogPostsController(IBlogPostsRepository blogPostsRepository)
        {
            _blogPostsRepository = blogPostsRepository;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> GetByIdAsync(int id)
        {
            BlogPost post = await _blogPostsRepository.GetByIdAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }


        [HttpGet]
        public async Task<ActionResult<BlogPost>> GetAllAsync()
        {
            IEnumerable<BlogPost> posts = await _blogPostsRepository.GetAllAsync();
            return Ok(posts);
        }


        [HttpPost]
        public async Task<ActionResult<BlogPost>> Create([FromBody] BlogPost post)
        {
            if (post == null)
            {
                return BadRequest();
            }

            await _blogPostsRepository.AddAsync(post);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = post.Id }, post);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] BlogPost post)
        {
            if (post == null || id != post.Id)
            {
                return BadRequest();
            }

            BlogPost existingPost = await _blogPostsRepository.GetByIdAsync(id);

            if (existingPost == null)
            {
                return NotFound();
            }

            existingPost.Title = post.Title;
            existingPost.Body = post.Body;
            existingPost.UpdatedAt = DateTime.UtcNow;

            await _blogPostsRepository.UpdateAsync(existingPost);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            BlogPost post = await _blogPostsRepository.GetByIdAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            await _blogPostsRepository.DeleteAsync(post);
            return NoContent();
        }
    }
}
