using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManager.Mvc.Migrations
{
    public partial class ProcessSpecificPropertiesToExaminationAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage",
                table: "ExaminationAnswers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WasSuccessfullyProcessed",
                table: "ExaminationAnswers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrorMessage",
                table: "ExaminationAnswers");

            migrationBuilder.DropColumn(
                name: "WasSuccessfullyProcessed",
                table: "ExaminationAnswers");
        }
    }
}
