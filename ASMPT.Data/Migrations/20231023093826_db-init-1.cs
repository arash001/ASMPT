using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASMPT.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbinit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Students");
        }
    }
}
