using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Services.ExtensionsAPI.Migrations
{
    public partial class TablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    ExampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExampleImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExampleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExampleDouble = table.Column<double>(type: "float", nullable: false),
                    ExampleInt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.ExampleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColumnDouble = table.Column<double>(type: "float", nullable: false),
                    ColumnImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnInt = table.Column<int>(type: "int", nullable: false),
                    ColumnString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });
        }
    }
}
