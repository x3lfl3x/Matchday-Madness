using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchdayMadness2.Migrations
{
    /// <inheritdoc />
    public partial class db_fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Favorites");

            migrationBuilder.AlterColumn<int>(
                name: "Teamsid",
                table: "Favorites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites",
                column: "Teamsid",
                principalTable: "Teams",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Teams_Teamsid",
                table: "Favorites");

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
                name: "TeamID",
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
    }
}
