using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzemBackendDotnet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Semester_semesterId",
                table: "course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_course",
                table: "course");

            migrationBuilder.RenameTable(
                name: "course",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_course_semesterId",
                table: "Course",
                newName: "IX_Course_semesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Semester_semesterId",
                table: "Course",
                column: "semesterId",
                principalTable: "Semester",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Semester_semesterId",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "course");

            migrationBuilder.RenameIndex(
                name: "IX_Course_semesterId",
                table: "course",
                newName: "IX_course_semesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_course",
                table: "course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Semester_semesterId",
                table: "course",
                column: "semesterId",
                principalTable: "Semester",
                principalColumn: "Id");
        }
    }
}
