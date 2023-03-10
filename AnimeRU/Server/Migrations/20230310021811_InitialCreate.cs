using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeRU.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImageURL", "Name", "Video" },
                values: new object[,]
                {
                    { 1, "https://flxt.tmsimg.com/assets/p13993632_b_v8_ab.jpg", "Attack On Titan - Episodul 1", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 2, "https://m.media-amazon.com/images/M/MV5BM2RmZmI2NmUtNDhjMi00MGQ4LWIyYTEtZmMxM2E1ZjBkYTU0XkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg", "Domestic No Kanojo - Episodul 1", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 3, "https://static.wikia.nocookie.net/tokyoghoul/images/9/9b/Season_two_blu-ray_box_cover.png/revision/latest?cb=20161204225315", "Tokyo Ghoul - Episodul 1", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 4, "https://m.media-amazon.com/images/M/MV5BNjMxMDJkNGQtMDkwMy00ZmQyLThjNWQtODYyODU2MmYwYTA1XkEyXkFqcGdeQXVyMTQ3MjMyMTYz._V1_.jpg", "Kuroko no basket - Episodul 1", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 5, "https://static.wikia.nocookie.net/jujutsu-kaisen/images/8/88/Anime_Key_Visual_2.png/revision/latest?cb=20201212034001", "Jujutsu Kaisen - Episodul 1", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 6, "https://flxt.tmsimg.com/assets/p13993632_b_v8_ab.jpg", "Attack On Titan - Episodul 2", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 7, "https://m.media-amazon.com/images/M/MV5BM2RmZmI2NmUtNDhjMi00MGQ4LWIyYTEtZmMxM2E1ZjBkYTU0XkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg", "Domestic No Kanojo - Episodul 2", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 8, "https://static.wikia.nocookie.net/tokyoghoul/images/9/9b/Season_two_blu-ray_box_cover.png/revision/latest?cb=20161204225315", "Tokyo Ghoul - Episodul 2", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 9, "https://m.media-amazon.com/images/M/MV5BNjMxMDJkNGQtMDkwMy00ZmQyLThjNWQtODYyODU2MmYwYTA1XkEyXkFqcGdeQXVyMTQ3MjMyMTYz._V1_.jpg", "Kuroko no basket - Episodul 2", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" },
                    { 10, "https://static.wikia.nocookie.net/jujutsu-kaisen/images/8/88/Anime_Key_Visual_2.png/revision/latest?cb=20201212034001", "Jujutsu Kaisen - Episodul 2", "https://mega.nz/embed/ERYTUSwZ#CtpBVQBt66T8i4YX5bdnBxoeOGfQxXYZ1c6RTTlPLqg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
