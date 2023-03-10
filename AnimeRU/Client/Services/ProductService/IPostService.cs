namespace AnimeRU.Client.Services.PostService
{
	public interface IPostService
	{
		 List<Post> Posts { get; set; }

		Task GetPosts();
	}
}
