using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodlamaIODemo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InstructorAndStudentImagePathUpdateMySql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Students",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Instructors",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Instructors");
        }
    }
}
