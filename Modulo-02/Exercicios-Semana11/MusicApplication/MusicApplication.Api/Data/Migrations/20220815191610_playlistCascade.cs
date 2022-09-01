using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApplication.Api.Data.Migrations
{
    public partial class playlistCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "Musicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistId",
                table: "Musicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Playlists_PlaylistId",
                table: "Musicas",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id");
        }
    }
}
