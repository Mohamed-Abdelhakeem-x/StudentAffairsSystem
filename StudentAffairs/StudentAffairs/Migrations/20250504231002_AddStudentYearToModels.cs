using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAffairs.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentYearToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentYear",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentYear",
                table: "Lectures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentYear",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentYear",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "StudentYear",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "StudentYear",
                table: "AspNetUsers");
        }
    }
}
