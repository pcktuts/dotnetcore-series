using Microsoft.EntityFrameworkCore.Migrations;

namespace learndotnetcore.Migrations
{
    public partial class Changecolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_CreatedById",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Review",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CreatedById",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Review",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Review",
                newName: "IX_Review_CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_CreatedById",
                table: "Review",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
