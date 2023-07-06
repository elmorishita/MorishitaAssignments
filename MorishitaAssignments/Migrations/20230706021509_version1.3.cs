using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorishitaAssignments.Migrations
{
    public partial class version13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentAccessLevel",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "Grade", "LastName", "StudentAccessLevel" },
                values: new object[,]
                {
                    { 1, "Sharean", "12", "Vesey", 9 },
                    { 2, "Dewayne", "9", "Mori", 6 },
                    { 3, "Esiah", "9", "Lonnell", 6 },
                    { 4, "Elizabeth", "8", "Shalonda", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "StudentAccessLevel",
                table: "Students");
        }
    }
}
