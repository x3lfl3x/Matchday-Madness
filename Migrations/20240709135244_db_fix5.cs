using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchdayMadness2.Migrations
{
    /// <inheritdoc />
    public partial class db_fix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_Teamsid",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Teamsid",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_Teamsid",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "Teamsid",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Teamsid",
                table: "Favorites");

            migrationBuilder.CreateIndex(
                name: "IX_Players_Team_ID",
                table: "Players",
                column: "Team_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_Team_ID",
                table: "Favorites",
                column: "Team_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Teams_Team_ID",
                table: "Favorites",
                column: "Team_ID",
                principalTable: "Teams",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_Team_ID",
                table: "Players",
                column: "Team_ID",
                principalTable: "Teams",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Team_ID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_Team_ID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Team_ID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_Team_ID",
                table: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "Teamsid",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Teamsid",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Teamsid",
                table: "Players",
                column: "Teamsid");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_Teamsid",
                table: "Favorites",
                column: "Teamsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_Teamsid",
                table: "Players",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
