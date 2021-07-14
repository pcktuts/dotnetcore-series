using Microsoft.EntityFrameworkCore.Migrations;

namespace learndotnetcore.Migrations
{
    public partial class AddReviewCreatedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Review",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_CreatedById",
                table: "Review",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_CreatedById",
                table: "Review",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_CreatedById",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_CreatedById",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Review");
        }
    }
}
