using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ratry.Data.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Duty",
                columns: table => new
                {
                    DutyId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    day = table.Column<string>(nullable: true),
                    hour = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duty", x => x.DutyId);
                    table.ForeignKey(
                        name: "FK_Duty_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Security",
                        principalTable: "AspNetUser",
                        principalColumn: "AspNetUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Duty_UserId",
                table: "Duty",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Duty");
        }
    }
}
