using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorishitaAssignments.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "Assigns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assigns",
                table: "Assigns",
                column: "AssignmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Assigns",
                table: "Assigns");

            migrationBuilder.RenameTable(
                name: "Assigns",
                newName: "Assignments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "AssignmentId");
        }
    }
}
