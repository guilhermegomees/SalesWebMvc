﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_SalesRecord_StatusId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_StatusId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SalesRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "SalesRecord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_StatusId",
                table: "SalesRecord",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_SalesRecord_StatusId",
                table: "SalesRecord",
                column: "StatusId",
                principalTable: "SalesRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
