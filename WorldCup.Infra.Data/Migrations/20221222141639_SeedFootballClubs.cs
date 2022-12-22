using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCup.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFootballClubs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO FootballClubs (Country,Image) " + "VALUES ('Uruguay','uruguay.jpeg')");
            migrationBuilder.Sql("INSERT INTO FootballClubs (Country,Image) " + "VALUES ('Germany','germany.jpeg')");
            migrationBuilder.Sql("INSERT INTO FootballClubs (Country,Image) " + "VALUES ('Argentine','argentine.jpeg')");

        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM FootballClubs");
        }
    }
}
