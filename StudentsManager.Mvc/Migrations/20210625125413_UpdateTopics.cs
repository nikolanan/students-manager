using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManager.Mvc.Migrations
{
    public partial class UpdateTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE [dbo].[Topics] SET [CourseId] = '788f26d7-b885-4568-99d5-ef83e4e88ef4'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE [dbo].[Topics] SET [CourseId] = NULL");
        }
    }
}
