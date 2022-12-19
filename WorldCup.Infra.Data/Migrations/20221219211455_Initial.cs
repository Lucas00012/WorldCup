using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorldCup.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballClubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballClubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CupTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupYear = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChampionFootballClubId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CupTitles_FootballClubs_ChampionFootballClubId",
                        column: x => x.ChampionFootballClubId,
                        principalTable: "FootballClubs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CupTitles",
                columns: new[] { "Id", "ChampionFootballClubId", "CupYear", "Location" },
                values: new object[,]
                {
                    { 1, null, 1930, "Uruguay" },
                    { 2, null, 2014, "Brazil" },
                    { 3, null, 2022, "Qatar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CupTitles_ChampionFootballClubId",
                table: "CupTitles",
                column: "ChampionFootballClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CupTitles");

            migrationBuilder.DropTable(
                name: "FootballClubs");
        }
    }
}
