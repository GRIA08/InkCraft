using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InkCraft.Migrations
{
    /// <inheritdoc />
    public partial class RenameColorToQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Paper");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Paper",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Paper");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
