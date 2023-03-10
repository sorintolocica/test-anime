using AnimeRU.Shared;

namespace AnimeRU.Server.Services.PostService
{
	public interface IPostService
	{
		Task<ServiceResponse<List<Post>>> GetPostsAsync();
		Task<ServiceResponse<Post>> GetPostsAsync(int postId);

		Task<ServiceResponse<Post>> DeletePostAsync(int postId);
		Task<ServiceResponse<Post>> UpdatePostAsync(int postId, Post post);

		Task<ServiceResponse<Post>> CreatePostAsync(Post post);
	}
}

