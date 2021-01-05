using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class UserAnswerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_Questions_QuestionId",
                table: "UserAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_Quiz_QuizId",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_QuestionId",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_QuizId",
                table: "UserAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuizId_QuestionId",
                table: "UserAnswer",
                columns: new[] { "QuizId", "QuestionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_QuizQuestions_QuizId_QuestionId",
                table: "UserAnswer",
                columns: new[] { "QuizId", "QuestionId" },
                principalTable: "QuizQuestions",
                principalColumns: new[] { "QuizId", "QuestionId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_QuizQuestions_QuizId_QuestionId",
                table: "UserAnswer");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswer_QuizId_QuestionId",
                table: "UserAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuestionId",
                table: "UserAnswer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuizId",
                table: "UserAnswer",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_Questions_QuestionId",
                table: "UserAnswer",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_Quiz_QuizId",
                table: "UserAnswer",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
