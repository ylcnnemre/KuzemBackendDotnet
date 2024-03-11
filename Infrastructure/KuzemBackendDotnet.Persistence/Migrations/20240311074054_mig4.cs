using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzemBackendDotnet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Semester_SemesterId",
                table: "course");

            migrationBuilder.RenameColumn(
                name: "SemesterId",
                table: "course",
                newName: "semesterId");

            migrationBuilder.RenameIndex(
                name: "IX_course_SemesterId",
                table: "course",
                newName: "IX_course_semesterId");

            migrationBuilder.AlterColumn<Guid>(
                name: "semesterId",
                table: "course",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Semester_semesterId",
                table: "course",
                column: "semesterId",
                principalTable: "Semester",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Semester_semesterId",
                table: "course");

            migrationBuilder.RenameColumn(
                name: "semesterId",
                table: "course",
                newName: "SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_course_semesterId",
                table: "course",
                newName: "IX_course_SemesterId");

            migrationBuilder.AlterColumn<Guid>(
                name: "SemesterId",
                table: "course",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_course_Semester_SemesterId",
                table: "course",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
