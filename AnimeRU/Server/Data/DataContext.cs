namespace AnimeRU.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Name = "Attack On Titan - Episodul 1",
                    ImageURL = "https://flxt.tmsimg.com/assets/p13993632_b_v8_ab.jpg",
                    Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					Id = 2,
					Name = "Domestic No Kanojo - Episodul 1",
					ImageURL = "https://m.media-amazon.com/images/M/MV5BM2RmZmI2NmUtNDhjMi00MGQ4LWIyYTEtZmMxM2E1ZjBkYTU0XkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					 Id = 3,
					 Name = "Tokyo Ghoul - Episodul 1",
					 ImageURL = "https://static.wikia.nocookie.net/tokyoghoul/images/9/9b/Season_two_blu-ray_box_cover.png/revision/latest?cb=20161204225315",
					 Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					 Id = 4,
					 Name = "Kuroko no basket - Episodul 1",
					 ImageURL = "https://m.media-amazon.com/images/M/MV5BNjMxMDJkNGQtMDkwMy00ZmQyLThjNWQtODYyODU2MmYwYTA1XkEyXkFqcGdeQXVyMTQ3MjMyMTYz._V1_.jpg",
					 Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},


				new Post
				{
					Id = 5,
					Name = "Jujutsu Kaisen - Episodul 1",
					ImageURL = "https://static.wikia.nocookie.net/jujutsu-kaisen/images/8/88/Anime_Key_Visual_2.png/revision/latest?cb=20201212034001",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					Id = 6,
					Name = "Attack On Titan - Episodul 2",
					ImageURL = "https://flxt.tmsimg.com/assets/p13993632_b_v8_ab.jpg",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					Id = 7,
					Name = "Domestic No Kanojo - Episodul 2",
					ImageURL = "https://m.media-amazon.com/images/M/MV5BM2RmZmI2NmUtNDhjMi00MGQ4LWIyYTEtZmMxM2E1ZjBkYTU0XkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					Id = 8,
					Name = "Tokyo Ghoul - Episodul 2",
					ImageURL = "https://static.wikia.nocookie.net/tokyoghoul/images/9/9b/Season_two_blu-ray_box_cover.png/revision/latest?cb=20161204225315",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},

				new Post
				{
					Id = 9,
					Name = "Kuroko no basket - Episodul 2",
					ImageURL = "https://m.media-amazon.com/images/M/MV5BNjMxMDJkNGQtMDkwMy00ZmQyLThjNWQtODYyODU2MmYwYTA1XkEyXkFqcGdeQXVyMTQ3MjMyMTYz._V1_.jpg",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				},


				new Post
				{
					Id = 10,
					Name = "Jujutsu Kaisen - Episodul 2",
					ImageURL = "https://static.wikia.nocookie.net/jujutsu-kaisen/images/8/88/Anime_Key_Visual_2.png/revision/latest?cb=20201212034001",
					Video = "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg"
				}
				
				);
        }

		public DbSet<Post> Posts { get; set; }

    }
}
