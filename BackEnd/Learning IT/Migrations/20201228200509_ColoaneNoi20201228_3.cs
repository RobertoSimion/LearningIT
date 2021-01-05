﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Learning_IT.Migrations
{
    public partial class ColoaneNoi20201228_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Time",
                table: "Chapters",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Chapters");
        }
    }
}