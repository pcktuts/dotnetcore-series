using Microsoft.EntityFrameworkCore.Migrations;

namespace learndotnetcore.Migrations
{
    public partial class ReviewChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Review",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Review",
                newName: "ReviewId");
        }
    }
}
