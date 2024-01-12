using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairTrade_API.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "This decorative candleholder is handcrafted from Phoenician Glass, made from recycled bottles. Handwash only, holds 14oz.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image" },
                values: new object[] { "This candle bears the wonderful scent of lemon, jasmine, cedar and a hint of musk! Made by fair trade artisans.", "https://volunimages.blob.core.windows.net/volun/candles.png" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/chocolate.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua.", "https://volunimages.blob.core.windows.net/volun/coffee.png" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image" },
                values: new object[] { "It is grown in the mountains a stone’s throw from Nicaragua’s famous cigar rollers and is drunk by them every day.", "https://volunimages.blob.core.windows.net/volun/coffee1.png" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image" },
                values: new object[] { "The original Zambeezi lip balm has a wild gingery lemongrass flavor with organically grown, Fair Trade ingredients.", "https://volunimages.blob.core.windows.net/volun/lipbalm.png" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/soap.png");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Fair trade tea from small-scale farmers in Kenya is some of the world's most flavorful. Peppermint Detox packed with antioxidants,");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image" },
                values: new object[] { "These natural jug vases are a fair trade product handmade in Kenya. They are hand carved out of stone and then sanded until smooth.", "https://volunimages.blob.core.windows.net/volun/vase.png" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "This decorative candleholder is handcrafted from Phoenician Glass, made from recycled bottles. Handwash only, holds 14oz. Dimensions: 3\"D x 4\"H. Made by fair trade artisans in West Bank.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image" },
                values: new object[] { "This candle bears the wonderful scent of lemon, jasmine, cedar and a hint of musk! Made by fair trade artisans. ", "https://volunimages.blob.core.windows.net/volun/candles.webp" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/chocolate.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua. Exhibiting this artisanal fruit-curing, Honey Bear is truly a reserve coffee.", "https://volunimages.blob.core.windows.net/volun/coffee1.webp" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image" },
                values: new object[] { "No finer partner exists for a premium cigar than this coffee. It is grown in the mountains a stone’s throw from Nicaragua’s famous cigar rollers and is drunk by them every day.", "https://volunimages.blob.core.windows.net/volun/coffee2.webp" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image" },
                values: new object[] { "The original Zambeezi lip balm has a wild gingery lemongrass flavor with organically grown, Fair Trade ingredients you will totally fall for.", "https://volunimages.blob.core.windows.net/volun/lipbalm.webp" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://volunimages.blob.core.windows.net/volun/soap.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Fair trade tea from small-scale farmers in Kenya is some of the world's most flavorful. Peppermint Detox is packed with antioxidants, whole leaf peppermint, and lemongrass to create this delicious and revitalizing blend.");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image" },
                values: new object[] { "These natural jug vases are a fair trade product handmade in Kenya. They are hand carved out of stone and then sanded until smooth. Since these vases show the natural colors of the stone, some color variations should be expected.", "https://volunimages.blob.core.windows.net/volun/vases.webp" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design. Made by fair trade artisans in India. Dimensions: 32\"Lx18.5\"H.");
        }
    }
}
