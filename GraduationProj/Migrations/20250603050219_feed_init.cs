using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProj.Migrations
{
    /// <inheritdoc />
    public partial class feed_init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var products = new (int Id, string Name, string Category, decimal Price)[]
            {
                (1, "Apple 2024 MacBook Air 13-inch Laptop", "Computer", 999.99m),
                (2, "Apple 2024 MacBook Pro Laptop", "Computer", 1299.99m),
                (3, "Apple Airpods Max Over Ear Headphone", "headphones", 549.99m),
                (4, "Apple AirPods Pro (2nd Generation)", "headphones", 249.99m),
                (5, "Apple iPhone 11 64GB Purple (M05P3)", "phones", 399.99m),
                (6, "Apple iPhone 12 64GB Black (M02B3)", "phones", 499.99m),
                (7, "Apple IPhone 16 Plus", "phones", 1099.99m),
                (8, "Apple iPhone 16 ProMax", "phones", 1399.99m),
                (9, "Apple iPhone SE 128GB Red (M03R3)", "phones", 429.99m),
                (10, "Apple iPhone X 256GB Silver (M04S3)", "phones", 599.99m),
                (11, "Apple Macbook Air 2020 Model", "Computer", 899.99m),
                (12, "Apple Watch SE (2nd Gen)", "smartwatches", 249.99m),
                (13, "Apple Watch Ultra 2 [GPS + Cellular 49mm]", "smartwatches", 799.99m),
                (14, "DualSense Edge PS5 Controller", "Gaming", 199.99m),
                (15, "DualSense PS5 Controller", "Gaming", 69.99m),
                (16, "HP Victus FA0033DX", "Computer", 849.99m),
                (17, "HUAWEI Watch FIT 3", "smartwatches", 129.99m),
                (18, "JBL Tune 720BT - Wireless Over-Ear Headphones", "headphones", 79.99m),
                (19, "Lenovo Legion 5 Laptop", "Computer", 1199.99m),
                (20, "Lenovo LOQ 15IRX9 Gaming", "Computer", 1099.99m),
                (21, "LogiTech Steering Wheel for PS5", "Gaming", 299.99m),
                (22, "Samsung Galaxy S25 Ultra", "phones", 1299.99m),
                (23, "SAMSUNG Galaxy Watch Ultra Smartwatch", "smartwatches", 399.99m),
                (24, "Samsung Galaxy Watch7 Classic Smartwatch", "smartwatches", 349.99m),
                (25, "Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch", "smartwatches", 379.99m),
                (26, "Sony PS5 PRO", "Gaming", 599.99m),
                (27, "Sony PS5 with 2 Controllers", "Gaming", 549.99m),
                (28, "Sony WH-1000XM5", "headphones", 399.99m),
                (29, "Sony WH-CH720N Noise Canceling Wireless Headphones", "headphones", 149.99m),
                (30, "SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard", "Gaming", 249.99m)
            };

            foreach (var p in products)
            {
                var sanitized = p.Name.Replace("'", "''");
                var imagePath = $"{sanitized}.png";
                var detailsPath = $"{sanitized}/0.png;1.png;2.png;3.png";

                migrationBuilder.InsertData(
                    table: "Products",
                    columns: new[] { "Id", "Name", "Category", "Price" },
                    values: new object[] { p.Id, sanitized, p.Category, p.Price });

                migrationBuilder.InsertData(
                    table: "ProductsDetails",
                    columns: new[] { "Id", "Details", "ImagePaths", "ProductId" },
                    values: new object[] { p.Id, $"Details for {sanitized}", detailsPath, p.Id });
            }
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete ProductsDetails rows first (FK to Products)
            for (int id = 1; id <= 30; id++)
            {
                migrationBuilder.DeleteData(
                    table: "ProductsDetails",
                    keyColumn: "Id",
                    keyValue: id);
            }

            // Delete Products rows
            for (int id = 1; id <= 30; id++)
            {
                migrationBuilder.DeleteData(
                    table: "Products",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }

    }
}
