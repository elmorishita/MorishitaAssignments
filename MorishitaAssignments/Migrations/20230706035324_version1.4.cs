using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorishitaAssignments.Migrations
{
    public partial class version14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessLevel",
                table: "Assigns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessLevel",
                table: "Assigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assigns",
                keyColumn: "AssignmentId",
                keyValue: 1,
                column: "AccessLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Assigns",
                keyColumn: "AssignmentId",
                keyValue: 2,
                column: "AccessLevel",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Assigns",
                keyColumn: "AssignmentId",
                keyValue: 3,
                column: "AccessLevel",
                value: 9);
        }
    }
}
