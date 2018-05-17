using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace isudns.Data.Migrations
{
    public partial class DropLocations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Conferentions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Conferentions",
                nullable: false,
                defaultValue: 0);
        }
    }
}
