using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsManager.Mvc.Migrations
{
    public partial class AddPointsToUserCoursework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "UserCourseworks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "UserCourseworks");
        }
    }
}
