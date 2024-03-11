using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzemBackendDotnet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "year",
                table: "Semester",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Semester",
                newName: "Active");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Semester",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Semester",
                newName: "active");
        }
    }
}
