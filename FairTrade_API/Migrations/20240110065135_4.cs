using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FairTrade_API.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StripePaymentIntentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.OrderHeaderId);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "OrderHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Home Decor", "This decorative candleholder is handcrafted from Phoenician Glass, made from recycled bottles. Handwash only, holds 14oz. Dimensions: 3\"D x 4\"H. Made by fair trade artisans in West Bank.", "https://volunimages.blob.core.windows.net/volun/candleholders.jpeg", "Candle Holder", 34.990000000000002, "" },
                    { 2, "Bath & Body", "This candle bears the wonderful scent of lemon, jasmine, cedar and a hint of musk! Made by fair trade artisans. ", "https://volunimages.blob.core.windows.net/volun/candles.webp", "Candle", 34.0, "" },
                    { 3, "Food & Beverage", "You will love this handscooped creation of Dark Chocolate 70% filled with whisky cream - contains alcohol!", "https://volunimages.blob.core.windows.net/volun/chocolate.jpg", "Dark Chocolate", 7.9900000000000002, "Best Seller" },
                    { 4, "Food & Beverage", "Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua. Exhibiting this artisanal fruit-curing, Honey Bear is truly a reserve coffee.", "https://volunimages.blob.core.windows.net/volun/coffee1.webp", "Haidi Coffee - Whole Bean", 22.0, "" },
                    { 5, "Food & Beverage", "No finer partner exists for a premium cigar than this coffee. It is grown in the mountains a stone’s throw from Nicaragua’s famous cigar rollers and is drunk by them every day.", "https://volunimages.blob.core.windows.net/volun/coffee2.webp", "Colombia Coffee", 22.0, "Top Rated" },
                    { 6, "Bath & Body", "The original Zambeezi lip balm has a wild gingery lemongrass flavor with organically grown, Fair Trade ingredients you will totally fall for.", "https://volunimages.blob.core.windows.net/volun/lipbalm.webp", "Organic Lip Balm", 4.9900000000000002, "" },
                    { 7, "Bath & Body", "This soap has a lemony scent and is great for hand soap or in the bath. Made fair trade in India.", "https://volunimages.blob.core.windows.net/volun/soap.jpg", "Lemon Chef's Soap", 5.9900000000000002, "" },
                    { 8, "Food & Beverage", "Fair trade tea from small-scale farmers in Kenya is some of the world's most flavorful. Peppermint Detox is packed with antioxidants, whole leaf peppermint, and lemongrass to create this delicious and revitalizing blend.", "https://volunimages.blob.core.windows.net/volun/tea.jpeg", "Peppermint Detox Loose Leaf Tea", 16.989999999999998, "" },
                    { 9, "Home Decor", "These natural jug vases are a fair trade product handmade in Kenya. They are hand carved out of stone and then sanded until smooth. Since these vases show the natural colors of the stone, some color variations should be expected.", "https://volunimages.blob.core.windows.net/volun/vases.webp", "Kisii Natural Jug Vase", 29.0, "" },
                    { 10, "Home Decor", "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design. Made by fair trade artisans in India. Dimensions: 32\"Lx18.5\"H.", "https://volunimages.blob.core.windows.net/volun/wall-art.jpeg", "Kantha Forest Wall Hanging", 89.989999999999995, "Top Rated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_MenuItemId",
                table: "CartItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuItemId",
                table: "OrderDetails",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "OrderHeaders");
        }
    }
}
