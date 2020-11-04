using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class AddedFKForUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Scores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scores_UserId1",
                table: "Scores",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_AspNetUsers_UserId1",
                table: "Scores",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_AspNetUsers_UserId1",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_UserId1",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Scores");
        }
    }
}
