using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alkalmazott",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nev = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Beosztas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonokId = table.Column<int>(type: "int", nullable: false),
                    Belepes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fizetes = table.Column<int>(type: "int", nullable: false),
                    Jutalom = table.Column<int>(type: "int", nullable: false),
                    OsztalyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alkalmazott", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alkalmazott");
        }
    }
}
