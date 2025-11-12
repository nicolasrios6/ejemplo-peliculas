using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ejemplo_peliculas.Migrations
{
    /// <inheritdoc />
    public partial class CambioImagenUrlPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenPerfilUrl",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrlPerfil",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenUrlPerfil",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ImagenPerfilUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
