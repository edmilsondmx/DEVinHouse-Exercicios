using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApplication.Api.Data.Migrations
{
    public partial class AddPlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "Musicas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Estilo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_PlaylistId",
                table: "Musicas",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Musicas_PlaylistId",
                table: "Musicas");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Musicas");
        }
    }
}
