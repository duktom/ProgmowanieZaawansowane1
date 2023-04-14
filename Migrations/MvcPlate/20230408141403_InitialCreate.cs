﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedProgramming_Lesson1.Migrations.MvcPlate
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diameter = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plate", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plate");
        }
    }
}
