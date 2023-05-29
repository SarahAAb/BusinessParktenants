using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessParktenants.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Suggestions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_UserId",
                table: "Suggestions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
