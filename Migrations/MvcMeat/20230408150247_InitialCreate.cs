﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedProgramming_Lesson1.Migrations.MvcMeat
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    MeatType = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    FatPercetage = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meat", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meat");
        }
    }
}
