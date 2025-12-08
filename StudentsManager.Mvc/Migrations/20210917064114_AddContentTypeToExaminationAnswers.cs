using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManager.Mvc.Migrations
{
    public partial class AddContentTypeToExaminationAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "ExaminationAnswers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "ExaminationAnswers");
        }
    }
}
