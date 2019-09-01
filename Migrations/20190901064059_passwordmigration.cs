using Microsoft.EntityFrameworkCore.Migrations;

namespace MazharCourseProject.Migrations
{
    public partial class passwordmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "users");

            migrationBuilder.DropColumn(
                name: "email",
                table: "users");
        }
    }
}
