using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace isudns.Data.Migrations
{
    public partial class Links : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Articles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ApplicationUserId",
                table: "Articles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_ApplicationUserId",
                table: "Articles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_ApplicationUserId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ApplicationUserId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Articles");
        }
    }
}
