using AnimeRU.Client.Services.PostService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Common;
using System.Net.Http.Headers;

namespace AnimeRU.Server.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly DataContext _context;

        public PostService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Post>> CreatePostAsync(Post posts)
        {
            var post = new Post()
            {
                Id = posts.Id,
                Name = posts.Name,
                ImageURL = posts.ImageURL,
                Video = posts.Video
            };

            try
            {
                _context.Posts.Add(posts);
                await _context.SaveChangesAsync();

                return new ServiceResponse<Post>
                {
                    Success = true,
                    Data = post
                };
            }
            catch (DbException ex)
            {
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = ex.Message
                };
            }
            catch (Exception ex)
            {
                // Log the error here
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = "Nu s-a putut creea postarea."
                };
            }
        }

        public async Task<ServiceResponse<Post>> DeletePostAsync(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = "Postare nu a fost gasita."
                };
            }

            try
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = ex.Message
                };
            }

            return new ServiceResponse<Post>
            {
                Success = true,
                Data = post
            };
        }

        public async Task<ServiceResponse<List<Post>>> GetPostsAsync()
        {
            var response = new ServiceResponse<List<Post>>
            {
                Data = await _context.Posts.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Post>> GetPostsAsync(int postId)
        {
            var response = new ServiceResponse<Post>();
            var post = await _context.Posts.FindAsync(postId);
            if (post == null)
            {
                response.Success = false;
                response.Message = "Acest anime nu exista...";
            }
            else
            {
                response.Data = post;
            }

            return response;
        }

        public async Task<ServiceResponse<Post>> UpdatePostAsync(int postId, Post updatedPost)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = "Postare nu a fost gasita."
                };
            }

            post.Name = updatedPost.Name;
            post.ImageURL = updatedPost.ImageURL;
            post.Video = updatedPost.Video;

            try
            {
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Post>
                {
                    Success = false,
                    Message = ex.Message
                };
            }

            return new ServiceResponse<Post>
            {
                Success = true,
                Data = post
            };
        }
    }
}
