using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace isudns.Data.Migrations
{
    public partial class wtf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Conferentions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Conferentions");
        }
    }
}
