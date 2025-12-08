using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StudentsManager.Mvc.Migrations
{
    public partial class AddForum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumQuestions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumQuestionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumComments_ForumQuestions_ForumQuestionId",
                        column: x => x.ForumQuestionId,
                        principalTable: "ForumQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_ForumQuestionId",
                table: "ForumComments",
                column: "ForumQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_UserId",
                table: "ForumComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumQuestions_UserId",
                table: "ForumQuestions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumComments");

            migrationBuilder.DropTable(
                name: "ForumQuestions");
        }
    }
}
