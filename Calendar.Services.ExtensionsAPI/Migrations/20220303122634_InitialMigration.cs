using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Services.ExtensionsAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColumnDouble = table.Column<double>(type: "float", nullable: false),
                    ColumnInt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tables");
        }
    }
}
