using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchdayMadness2.Migrations
{
    /// <inheritdoc />
    public partial class dbfix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Teamsid",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Teamsid",
                table: "Teams",
                column: "Teamsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Teams_Teamsid",
                table: "Teams",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Teams_Teamsid",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Teamsid",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Teamsid",
                table: "Teams");
        }
    }
}
