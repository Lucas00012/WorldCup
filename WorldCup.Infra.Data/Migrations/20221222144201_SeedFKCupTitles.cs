using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCup.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFKCupTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE CupTitles SET ChampionFootballClubId = 9" + "WHERE Id = 3");
            migrationBuilder.Sql("UPDATE CupTitles SET ChampionFootballClubId = 8" + "WHERE Id = 2");
            migrationBuilder.Sql("UPDATE CupTitles SET ChampionFootballClubId = 7" + "WHERE Id = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ChampionFootballClubId");
         
        }
    }
}
