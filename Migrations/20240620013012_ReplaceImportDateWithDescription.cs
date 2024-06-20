using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InkCraft.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceImportDateWithDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImportDate",
                table: "Paper");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Paper");

            migrationBuilder.AddColumn<DateTime>(
                name: "ImportDate",
                table: "Paper",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
