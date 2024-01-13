using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairTrade_API.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Haidi Coffee - whole bean. Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "This soap has a lemony scent and is great for hand soap or in the bath. Handmade by fair trade artisans in India.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Peppermint Detox Tea");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design. Made by fair trade artisans in India.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "This soap has a lemony scent and is great for hand soap or in the bath. Made fair trade in India.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Peppermint Detox Loose Leaf Tea");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design.");
        }
    }
}
