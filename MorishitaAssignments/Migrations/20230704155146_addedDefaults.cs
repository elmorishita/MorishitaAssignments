using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorishitaAssignments.Migrations
{
    public partial class addedDefaults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentSeven",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "AssignmentSix",
                table: "Assignments",
                newName: "AssignmentName");

            migrationBuilder.AddColumn<int>(
                name: "AccessLevel",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "AccessLevel", "AssignmentName" },
                values: new object[] { 1, 1, "Assignment 6.1" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "AccessLevel", "AssignmentName" },
                values: new object[] { 2, 5, "Assignment 7.1" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "AccessLevel", "AssignmentName" },
                values: new object[] { 3, 9, "Assignment 8.5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AccessLevel",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "AssignmentName",
                table: "Assignments",
                newName: "AssignmentSix");

            migrationBuilder.AddColumn<string>(
                name: "AssignmentSeven",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
