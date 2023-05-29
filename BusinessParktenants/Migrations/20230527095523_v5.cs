using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessParktenants.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complains_AspNetUsers_UserId",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Suggestions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Complains",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_AspNetUsers_UserId",
                table: "Complains",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complains_AspNetUsers_UserId",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Suggestions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Complains",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_AspNetUsers_UserId",
                table: "Complains",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suggestions_AspNetUsers_UserId",
                table: "Suggestions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
