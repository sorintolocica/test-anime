using AnimeRU.Client.Services.PostService;
using AnimeRU.Server.Services.PostService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimeRU.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly Services.PostService.IPostService _postService;

        public PostController(Services.PostService.IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]

        public async Task<ActionResult<ServiceResponse<List<Post>>>> GetPost()
        {
            var result = await _postService.GetPostsAsync();
            return Ok(result);
        }

        [HttpGet("{postId}")]

        public async Task<ActionResult<ServiceResponse<List<Post>>>> GetPost(int postId)
        {
            var result = await _postService.GetPostsAsync(postId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Post>>> CreatePost(Post posts)
        {
            var result = await _postService.CreatePostAsync(posts);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPut("{postId}")]
        public async Task<ActionResult<ServiceResponse<Post>>> UpdatePost(int postId, Post post)
        {
            var result = await _postService.UpdatePostAsync(postId, post);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }

        [HttpDelete("{postId}")]
        public async Task<ActionResult<ServiceResponse<Post>>> DeletePost(int postId)
        {
            var result = await _postService.DeletePostAsync(postId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }


    }
}
