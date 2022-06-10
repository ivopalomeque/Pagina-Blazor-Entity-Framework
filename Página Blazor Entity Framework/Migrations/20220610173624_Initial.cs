using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Página_Blazor_Entity_Framework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAnime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudioAnime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadEpisodios = table.Column<int>(type: "int", nullable: false),
                    FechaEmisión = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalización = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.AnimeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
