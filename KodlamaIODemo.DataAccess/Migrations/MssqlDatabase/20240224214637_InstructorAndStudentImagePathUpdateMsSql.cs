using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodlamaIODemo.DataAccess.Migrations.MssqlDatabase
{
    /// <inheritdoc />
    public partial class InstructorAndStudentImagePathUpdateMsSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Students",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Instructors",
                type: "nvarchar(200)",
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
