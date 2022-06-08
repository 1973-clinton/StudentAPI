using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Data.Migrations
{
    public partial class AddClassField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 54, 34, 525, DateTimeKind.Local).AddTicks(252), new DateTime(2022, 6, 8, 11, 54, 34, 525, DateTimeKind.Local).AddTicks(768) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 52, 6, 380, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 6, 8, 11, 52, 6, 380, DateTimeKind.Local).AddTicks(2125) });
        }
    }
}
