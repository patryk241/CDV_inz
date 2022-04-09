using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Services.ExtensionsAPI.Migrations
{
    public partial class TabChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDouble = table.Column<double>(type: "float", nullable: false),
                    EventInt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    ExampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExampleDouble = table.Column<double>(type: "float", nullable: false),
                    ExampleImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExampleInt = table.Column<int>(type: "int", nullable: false),
                    ExampleString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.ExampleId);
                });
        }
    }
}
