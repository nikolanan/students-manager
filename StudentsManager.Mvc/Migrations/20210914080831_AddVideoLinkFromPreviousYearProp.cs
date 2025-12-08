using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManager.Mvc.Migrations
{
    public partial class AddVideoLinkFromPreviousYearProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoLinkFromPreviousYear",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoLinkFromPreviousYear",
                table: "Topics");
        }
    }
}
