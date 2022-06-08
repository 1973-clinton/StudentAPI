using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StudentAPI.Data.Migrations
{
    public partial class AddEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 52, 6, 380, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 6, 8, 11, 52, 6, 380, DateTimeKind.Local).AddTicks(2125) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "DateOfBirth" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 40, 28, 59, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 6, 8, 11, 40, 28, 59, DateTimeKind.Local).AddTicks(4982) });
        }
    }
}
