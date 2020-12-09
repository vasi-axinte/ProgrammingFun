using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class AddedCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_UserId",
                table: "UserAnswer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer",
                columns: new[] { "UserId", "QuizId", "QuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuizId",
                table: "UserAnswer",
                column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_QuizId",
                table: "UserAnswer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer",
                columns: new[] { "QuizId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_UserId",
                table: "UserAnswer",
                column: "UserId");
        }
    }
}
