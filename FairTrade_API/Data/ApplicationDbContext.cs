using FairTrade_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FairTrade_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Candle Holder",
                Description = "This decorative candleholder is handcrafted from Phoenician Glass, made from recycled bottles. Handwash only, holds 14oz. Dimensions: 3\"D x 4\"H. Made by fair trade artisans in West Bank.",
                Image = "https://volunimages.blob.core.windows.net/volun/candleholders.jpeg",
                Price = 34.99,
                Category = "Home Decor",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 2,
                Name = "Candle",
                Description = "This candle bears the wonderful scent of lemon, jasmine, cedar and a hint of musk! Made by fair trade artisans. ",
                Image = "https://volunimages.blob.core.windows.net/volun/candles.webp",
                Price = 34.00,
                Category = "Bath & Body",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 3,
                Name = "Dark Chocolate",
                Description = "You will love this handscooped creation of Dark Chocolate 70% filled with whisky cream - contains alcohol!",
                Image = "https://volunimages.blob.core.windows.net/volun/chocolate.jpg",
                Price = 7.99,
                Category = "Food & Beverage",
                SpecialTag = "Best Seller"
            }, new MenuItem
            {
                Id = 4,
                Name = "Haidi Coffee Bean",
                Description = "Honey Bear Reserve, an ode to the artisanal‘honey' movement, was the first of its kind born in Nicaragua. Exhibiting this artisanal fruit-curing, Honey Bear is truly a reserve coffee.",
                Image = "https://volunimages.blob.core.windows.net/volun/coffee1.webp",
                Price = 22.00,
                Category = "Food & Beverage",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 5,
                Name = "Colombia Coffee",
                Description = "No finer partner exists for a premium cigar than this coffee. It is grown in the mountains a stone’s throw from Nicaragua’s famous cigar rollers and is drunk by them every day.",
                Image = "https://volunimages.blob.core.windows.net/volun/coffee2.webp",
                Price = 22.00,
                Category = "Food & Beverage",
                SpecialTag = "Top Rated"
            }, new MenuItem
            {
                Id = 6,
                Name = "Organic Lip Balm",
                Description = "The original Zambeezi lip balm has a wild gingery lemongrass flavor with organically grown, Fair Trade ingredients you will totally fall for.",
                Image = "https://volunimages.blob.core.windows.net/volun/lipbalm.webp",
                Price = 4.99,
                Category = "Bath & Body",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 7,
                Name = "Lemon Chef's Soap",
                Description = "This soap has a lemony scent and is great for hand soap or in the bath. Made fair trade in India.",
                Image = "https://volunimages.blob.core.windows.net/volun/soap.jpg",
                Price = 5.99,
                Category = "Bath & Body",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 8,
                Name = "Peppermint Detox Loose Leaf Tea",
                Description = "Fair trade tea from small-scale farmers in Kenya is some of the world's most flavorful. Peppermint Detox is packed with antioxidants, whole leaf peppermint, and lemongrass to create this delicious and revitalizing blend.",
                Image = "https://volunimages.blob.core.windows.net/volun/tea.jpeg",
                Price = 16.99,
                Category = "Food & Beverage",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 9,
                Name = "Kisii Natural Jug Vase",
                Description = "These natural jug vases are a fair trade product handmade in Kenya. They are hand carved out of stone and then sanded until smooth. Since these vases show the natural colors of the stone, some color variations should be expected.",
                Image = "https://volunimages.blob.core.windows.net/volun/vases.webp",
                Price = 29.00,
                Category = "Home Decor",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 10,
                Name = "Kantha Forest Wall Hanging",
                Description = "This wall decoration features a forest of kantha and recycled sari fabric to make for a wonderful design. Made by fair trade artisans in India. Dimensions: 32\"Lx18.5\"H.",
                Image = "https://volunimages.blob.core.windows.net/volun/wall-art.jpeg",
                Price = 89.99,
                Category = "Home Decor",
                SpecialTag = "Top Rated"
            });
        }
    }
}
