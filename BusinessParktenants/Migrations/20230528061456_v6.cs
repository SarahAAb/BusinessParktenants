using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessParktenants.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions");

            migrationBuilder.DropIndex(
                name: "IX_Suggestions_UserId",
                table: "Suggestions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Suggestions");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Complains",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Complains",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Complains");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Complains");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Suggestions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_UserId",
                table: "Suggestions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
