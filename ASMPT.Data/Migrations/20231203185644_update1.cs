using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASMPT.Data.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Students",
                newName: "Surename");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Authors",
                newName: "Surename");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surename",
                table: "Students",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Surename",
                table: "Authors",
                newName: "Surname");
        }
    }
}
