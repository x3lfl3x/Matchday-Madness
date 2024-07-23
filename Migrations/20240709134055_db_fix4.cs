using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchdayMadness2.Migrations
{
    /// <inheritdoc />
    public partial class db_fix4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Teams_Teamsid",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Teamsid",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Teamsid",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "Teamsid",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team_ID",
                table: "Favorites",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "Team_ID",
                table: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "Teamsid",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Teamsid",
                table: "Favorites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Teamsid",
                table: "Teams",
                column: "Teamsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Teams_Teamsid",
                table: "Teams",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id");
        }
    }
}
