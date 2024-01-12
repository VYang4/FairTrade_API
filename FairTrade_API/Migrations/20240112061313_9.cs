using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairTrade_API.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/candleholders.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/tea.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/wall-art.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/candleholders.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/tea.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/wall-art.jpeg");
        }
    }
}
