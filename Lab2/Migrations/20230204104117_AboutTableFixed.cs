using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    public partial class AboutTableFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCount",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "CourseTitle",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "EventCount",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "EventTitle",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "StudentTitle",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "TrainerTitle",
                table: "abouts");

            migrationBuilder.DropColumn(
                name: "Trainers",
                table: "abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCount",
                table: "abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CourseTitle",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EventCount",
                table: "abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EventTitle",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StudentTitle",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainerTitle",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Trainers",
                table: "abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
