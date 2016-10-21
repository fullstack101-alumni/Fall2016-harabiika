using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ratry.Data.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUser",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AspNetUsers",
                newName: "AspNetUserId");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUser",
                newSchema: "Security");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUser_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUser_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUser_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUser",
                schema: "Security",
                table: "AspNetUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                schema: "Security",
                table: "AspNetUser",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "Security",
                principalTable: "AspNetUser",
                principalColumn: "AspNetUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalSchema: "Security",
                principalTable: "AspNetUser",
                principalColumn: "AspNetUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalSchema: "Security",
                principalTable: "AspNetUser",
                principalColumn: "AspNetUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                schema: "Security",
                table: "AspNetUser",
                newName: "Id");

            migrationBuilder.RenameTable(
                name: "AspNetUser",
                schema: "Security",
                newName: "AspNetUsers");
        }
    }
}
