using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InkCraft.Migrations
{
    /// <inheritdoc />
    public partial class AddPaperTypeToPapers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Paper");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaperType",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaperType",
                table: "Paper");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
