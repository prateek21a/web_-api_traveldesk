using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDesk.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_CommonTypes_TravelFromId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_CommonTypes_TravelToId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TravelFromId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TravelToId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DomesticTravel",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "InternationalTrvel",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TravelDateFrom",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TravelDateTo",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TravelFromId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "TravelToId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "VisaNumber",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "CommentName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentName",
                table: "Comments");

            migrationBuilder.AddColumn<bool>(
                name: "DomesticTravel",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InternationalTrvel",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TravelDateFrom",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TravelDateTo",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TravelFromId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelToId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VisaNumber",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TravelFromId",
                table: "Comments",
                column: "TravelFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TravelToId",
                table: "Comments",
                column: "TravelToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_CommonTypes_TravelFromId",
                table: "Comments",
                column: "TravelFromId",
                principalTable: "CommonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_CommonTypes_TravelToId",
                table: "Comments",
                column: "TravelToId",
                principalTable: "CommonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
