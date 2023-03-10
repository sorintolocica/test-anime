namespace AnimeRU.Client.Services.PostService
{
	public class PostService : IPostService
	{
		private readonly HttpClient _http;

		public PostService(HttpClient http)
		{
			_http = http;
		}

		public List<Post> Posts { get; set; } = new List<Post>();

		public async Task GetPosts()
		{
			var result =
				await _http.GetFromJsonAsync<ServiceResponse<List<Post>>>("api/post");
			if(result != null && result.Data != null)
                Posts = result.Data.OrderByDescending(p => p.Id).ToList();
        }
	}
}
