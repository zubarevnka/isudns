using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace isudns.Data.Migrations
{
    public partial class FixConfIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conferentions_Locations_LocationID",
                table: "Conferentions");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Conferentions",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Conferentions_LocationID",
                table: "Conferentions",
                newName: "IX_Conferentions_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conferentions_Locations_LocationId",
                table: "Conferentions",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conferentions_Locations_LocationId",
                table: "Conferentions");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Conferentions",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Conferentions_LocationId",
                table: "Conferentions",
                newName: "IX_Conferentions_LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Conferentions_Locations_LocationID",
                table: "Conferentions",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
