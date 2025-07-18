using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProj.Migrations
{
    /// <inheritdoc />
    public partial class feed_related_products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1 (Apple 2024 MacBook Air 13-inch) ↔ 2, 11
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 1, 2 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 1, 11 });

            // 2 (Apple 2024 MacBook Pro) ↔ 1, 11
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 2, 1 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 2, 11 });

            // 3 (Airpods Max) ↔ 4, 18
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 3, 4 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 3, 18 });

            // 4 (AirPods Pro 2nd Gen) ↔ 3, 18
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 4, 3 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 4, 18 });

            // 5 (iPhone 11 64GB Purple) ↔ 6, 10
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 5, 6 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 5, 10 });

            // 6 (iPhone 12 64GB Black) ↔ 5, 10
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 6, 5 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 6, 10 });

            // 7 (iPhone 16 Plus) ↔ 8, 9
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 7, 8 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 7, 9 });

            // 8 (iPhone 16 ProMax) ↔ 7, 9
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 8, 7 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 8, 9 });

            // 9 (iPhone SE 128GB Red) ↔ 5, 6
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 9, 5 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 9, 6 });

            // 10 (iPhone X 256GB Silver) ↔ 5, 6
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 10, 5 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 10, 6 });

            // 11 (MacBook Air 2020) ↔ 1, 2
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 11, 1 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 11, 2 });

            // 12 (Apple Watch SE 2nd Gen) ↔ 13, 23
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 12, 13 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 12, 23 });

            // 13 (Apple Watch Ultra 2) ↔ 12, 23
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 13, 12 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 13, 23 });

            // 14 (DualSense Edge PS5 Controller) ↔ 15, 21
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 14, 15 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 14, 21 });

            // 15 (DualSense PS5 Controller) ↔ 14, 21
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 15, 14 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 15, 21 });

            // 16 (HP Victus FA0033DX) ↔ 19, 20
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 16, 19 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 16, 20 });

            // 17 (HUAWEI Watch FIT 3) ↔ 24, 25
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 17, 24 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 17, 25 });

            // 18 (JBL Tune 720BT) ↔ 3, 4
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 18, 3 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 18, 4 });

            // 19 (Lenovo Legion 5) ↔ 16, 20
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 19, 16 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 19, 20 });

            // 20 (Lenovo LOQ 15IRX9 Gaming) ↔ 16, 19
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 20, 16 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 20, 19 });

            // 21 (LogiTech Steering Wheel) ↔ 14, 15
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 21, 14 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 21, 15 });

            // 22 (Samsung Galaxy S25 Ultra) ↔ 5, 6
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 22, 5 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 22, 6 });

            // 23 (Galaxy Watch Ultra) ↔ 12, 13
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 23, 12 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 23, 13 });

            // 24 (Galaxy Watch7 Classic) ↔ 12, 17
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 24, 12 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 24, 17 });

            // 25 (Watch GT 5 Pro) ↔ 17, 23
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 25, 17 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 25, 23 });

            // 26 (Sony PS5 PRO) ↔ 27, 14
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 26, 27 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 26, 14 });

            // 27 (Sony PS5 with 2 Controllers) ↔ 26, 14
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 27, 26 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 27, 14 });

            // 28 (Sony WH-1000XM5) ↔ 29, 3
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 28, 29 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 28, 3 });

            // 29 (Sony WH-CH720N) ↔ 28, 18
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 29, 28 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 29, 18 });

            // 30 (SteelSeries Apex Pro Keyboard) ↔ 14, 15
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 30, 14 });
            migrationBuilder.InsertData(
                table: "ProductDetailsRelatedProducts",
                columns: new[] { "ProductDetailsId", "RelatedProductsId" },
                values: new object[] { 30, 15 });
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
    table: "ProductDetailsRelatedProducts",
    keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
    keyValues: new object[] { 1, 2 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 2, 1 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 3, 4 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 4, 3 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 5, 6 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
          table: "ProductDetailsRelatedProducts",
          keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
          keyValues: new object[] { 6, 5 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 7, 8 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 8, 7 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 9, 5 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 10, 5 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 11, 1 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 12, 13 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 13, 12 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 13, 23 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 14, 15 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 14, 21 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 15, 14 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 15, 21 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 16, 19 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 16, 20 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 17, 24 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 17, 25 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 18, 3 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 19, 16 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 20, 16 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 20, 19 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 21, 14 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 22, 5 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 23, 12 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 24, 12 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 25, 17 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 25, 23 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 26, 27 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 26, 14 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 27, 26 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 27, 14 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 28, 29 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 29, 28 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 29, 18 });

            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 30, 14 });
            migrationBuilder.DeleteData(
                table: "ProductDetailsRelatedProducts",
                keyColumns: new[] { "ProductDetailsId", "RelatedProductsId" },
                keyValues: new object[] { 30, 15 });
        }
    }
}
