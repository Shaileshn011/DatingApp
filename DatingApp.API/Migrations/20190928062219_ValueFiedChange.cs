using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class ValueFiedChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCity",
                table: "Values");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Values");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Values",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Values");

            migrationBuilder.AddColumn<string>(
                name: "UserCity",
                table: "Values",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Values",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
