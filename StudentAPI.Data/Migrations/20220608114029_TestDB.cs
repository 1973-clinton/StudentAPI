using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Data.Migrations
{
    public partial class TestDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 40, 28, 59, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 6, 8, 11, 40, 28, 59, DateTimeKind.Local).AddTicks(4982) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 7, 22, 40, 26, 270, DateTimeKind.Local).AddTicks(2517), new DateTime(2022, 6, 7, 22, 40, 26, 270, DateTimeKind.Local).AddTicks(3023) });
        }
    }
}
