using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class ValueFieldUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Values");

            migrationBuilder.AddColumn<string>(
                name: "UserCity",
                table: "Values",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Values",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
