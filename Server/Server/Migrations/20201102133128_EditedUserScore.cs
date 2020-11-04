using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class EditedUserScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Quiz_QuizId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_AspNetUsers_UserId1",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_QuizId",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_UserId1",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Scores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Scores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scores_QuizId",
                table: "Scores",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_UserId",
                table: "Scores",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Quiz_QuizId",
                table: "Scores",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_AspNetUsers_UserId",
                table: "Scores",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
