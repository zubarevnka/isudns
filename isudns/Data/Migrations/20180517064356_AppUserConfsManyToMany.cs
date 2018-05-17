using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace isudns.Data.Migrations
{
    public partial class AppUserConfsManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserConferention",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(nullable: false),
                    ConferentionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserConferention", x => new { x.ApplicationUserId, x.ConferentionId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserConferention_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserConferention_Conferentions_ConferentionId",
                        column: x => x.ConferentionId,
                        principalTable: "Conferentions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserConferention_ConferentionId",
                table: "ApplicationUserConferention",
                column: "ConferentionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserConferention");
        }
    }
}
