using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emlak.Otomasyon.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _202307070340 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "odasayisi",
                table: "Emlak",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "odasayisi",
                table: "Emlak");
        }
    }
}
