using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairTrade_API.Migrations
{
    /// <inheritdoc />
    public partial class addmigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Haidi Coffee Bean");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Haidi Coffee - Whole Bean");
        }
    }
}
