using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProj.Migrations
{
    /// <inheritdoc />
    public partial class feed_traits_init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "ProductTraits",
            columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
            values: new object[] { 1, "CPU", "Apple M2 chip (8-core CPU, 8-core GPU)", 1 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 2, "Memory", "8GB unified RAM", 1 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 3, "Storage", "256GB SSD", 1 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 4, "Display", "13.6-inch Liquid Retina (2560×1664)", 1 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 5, "Battery Life", "Up to 18 hours web browsing", 1 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 6, "Weight", "2.7 pounds (1.24 kg)", 1 });

            // ProductDetailsId = 2 (Apple 2024 MacBook Pro Laptop)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 7, "CPU", "Apple M2 Pro chip (10-core CPU)", 2 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 8, "Memory", "16GB unified RAM", 2 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 9, "Storage", "512GB SSD", 2 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 10, "Display", "14.2-inch Liquid Retina XDR (3024×1964)", 2 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 11, "GPU", "16-core GPU", 2 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 12, "Battery Life", "Up to 17 hours Apple TV app movie playback", 2 });

            // ProductDetailsId = 3 (Apple Airpods Max Over Ear Headphone)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 13, "Driver Size", "40mm dynamic drivers", 3 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 14, "Noise Cancellation", "Active Noise Cancellation with Transparency mode", 3 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 15, "Battery Life", "Up to 20 hours with ANC on", 3 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 16, "Connectivity", "Bluetooth 5.0", 3 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 17, "Weight", "13.6 ounces (385g)", 3 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 18, "Frequency Response", "10Hz to 20kHz", 3 });

            // ProductDetailsId = 4 (Apple AirPods Pro (2nd Generation))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 19, "Driver", "Custom high-excursion Apple driver", 4 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 20, "Noise Cancellation", "Adaptive Transparency and ANC", 4 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 21, "Battery Life", "Up to 6 hours listening; 30 hours with case", 4 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 22, "Chip", "Apple H2 chip", 4 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 23, "Connectivity", "Bluetooth 5.3", 4 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 24, "Weight", "0.2 ounces (5.3g) each", 4 });

            // ProductDetailsId = 5 (Apple iPhone 11 64GB Purple (M05P3))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 25, "Chip", "Apple A13 Bionic", 5 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 26, "Display", "6.1-inch Liquid Retina HD (1792×828)", 5 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 27, "Camera", "Dual 12MP Ultra Wide and Wide cameras", 5 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 28, "Battery Life", "Up to 17 hours video playback", 5 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 29, "Storage", "64GB", 5 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 30, "Weight", "194 grams", 5 });

            // ProductDetailsId = 6 (Apple iPhone 12 64GB Black (M02B3))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 31, "Chip", "Apple A14 Bionic", 6 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 32, "Display", "6.1-inch Super Retina XDR (2532×1170)", 6 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 33, "Camera", "Dual 12MP Ultra Wide and Wide with Night mode", 6 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 34, "Battery Life", "Up to 17 hours video playback", 6 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 35, "5G", "Sub-6GHz and mmWave", 6 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 36, "Weight", "164 grams", 6 });

            // ProductDetailsId = 7 (Apple IPhone 16 Plus)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 37, "Chip", "Apple A18 Pro", 7 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 38, "Display", "6.7-inch Super Retina XDR OLED (2796×1290)", 7 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 39, "RAM", "8GB LPDDR5X", 7 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 40, "Storage", "256GB", 7 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 41, "Camera", "48MP main, 12MP ultra-wide, 12MP telephoto", 7 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 42, "Battery Life", "Up to 28 hours talk time", 7 });

            // ProductDetailsId = 8 (Apple iPhone 16 ProMax)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 43, "Chip", "Apple A18 Pro Max", 8 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 44, "Display", "6.9-inch Super Retina XDR OLED ProMotion (2796×1290)", 8 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 45, "RAM", "12GB LPDDR5X", 8 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 46, "Storage", "512GB", 8 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 47, "Camera", "48MP main, 48MP ultra-wide, 12MP telephoto with 5× optical zoom", 8 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 48, "Battery Life", "Up to 30 hours video playback", 8 });

            // ProductDetailsId = 9 (Apple iPhone SE 128GB Red (M03R3))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 49, "Chip", "Apple A15 Bionic", 9 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 50, "Display", "4.7-inch Retina HD (1334×750)", 9 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 51, "Camera", "12MP wide camera", 9 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 52, "Battery Life", "Up to 15 hours video playback", 9 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 53, "Storage", "128GB", 9 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 54, "Weight", "144 grams", 9 });

            // ProductDetailsId = 10 (Apple iPhone X 256GB Silver (M04S3))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 55, "Chip", "Apple A11 Bionic", 10 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 56, "Display", "5.8-inch Super Retina HD (2436×1125)", 10 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 57, "Camera", "12MP dual cameras (wide and telephoto)", 10 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 58, "Battery Life", "Up to 21 hours talk time", 10 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 59, "Storage", "256GB", 10 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 60, "Weight", "174 grams", 10 });

            // ProductDetailsId = 11 (Apple Macbook Air 2020 Model)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 61, "CPU", "Intel Core i3-1000NG4 (10th gen)", 11 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 62, "Memory", "8GB DDR4 RAM", 11 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 63, "Storage", "256GB SSD", 11 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 64, "Display", "13.3-inch Retina (2560×1600)", 11 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 65, "Battery Life", "Up to 11 hours web", 11 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 66, "Weight", "2.8 pounds (1.29 kg)", 11 });

            // ProductDetailsId = 12 (Apple Watch SE (2nd Gen))
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 67, "Display", "Retina LTPO OLED (368×448)", 12 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 68, "Chip", "Apple S8 SiP", 12 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 69, "Sensors", "Heart rate, accelerometer, gyroscope", 12 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 70, "Battery Life", "Up to 18 hours", 12 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 71, "Water Resistance", "50 meters", 12 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 72, "Connectivity", "GPS/GNSS, Bluetooth 5.3, Wi-Fi", 12 });

            // ProductDetailsId = 13 (Apple Watch Ultra 2 [GPS + Cellular 49mm])
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 73, "Display", "Even-brighter Retina display (410×502)", 13 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 74, "Chip", "Apple S9 SiP", 13 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 75, "Sensors", "Depth gauge, compass, heart rate, SpO2", 13 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 76, "Battery Life", "Up to 36 hours normal use", 13 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 77, "Water Resistance", "100 meters", 13 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 78, "Connectivity", "GPS/GNSS, cellular, Bluetooth 5.3", 13 });

            // ProductDetailsId = 14 (DualSense Edge PS5 Controller)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 79, "Button Remapping", "Fully remappable triggers and buttons", 14 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 80, "Haptic Feedback", "Adaptive triggers and haptic motors", 14 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 81, "Connectivity", "Wireless Bluetooth & USB-C wired", 14 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 82, "Battery Life", "Up to 12 hours continuous play", 14 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 83, "Back Buttons", "Two programmable back buttons", 14 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 84, "Weight", "10.5 ounces (298g)", 14 });

            // ProductDetailsId = 15 (DualSense PS5 Controller)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 85, "Haptic Feedback", "Adaptive triggers and haptic motors", 15 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 86, "Connectivity", "Wireless Bluetooth & USB-C wired", 15 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 87, "Battery Life", "Up to 12 hours continuous play", 15 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 88, "Microphone", "Built-in mono mic", 15 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 89, "Speaker", "Built-in mono speaker", 15 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 90, "Weight", "9.8 ounces (280g)", 15 });

            // ProductDetailsId = 16 (HP Victus FA0033DX)
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 91, "CPU", "AMD Ryzen 5 5600H", 16 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 92, "GPU", "NVIDIA GeForce RTX 3060 (6GB GDDR6)", 16 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 93, "Memory", "8GB DDR4 RAM", 16 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 94, "Storage", "512GB SSD", 16 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 95, "Display", "15.6-inch FHD IPS (1920×1080) 144Hz", 16 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 96, "Battery Life", "Up to 6 hours mixed usage", 16 });

            // ProductDetailsId = 17 (HUAWEI Watch FIT 3) with starting Id = 103
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 103, "Display", "1.74-inch AMOLED (456×280)", 17 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 104, "Battery Life", "Up to 10 days typical use", 17 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 105, "Sensors", "Heart rate, SpO₂, accelerometer, gyroscope", 17 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 106, "Connectivity", "Bluetooth 5.2, GPS", 17 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 107, "Water Resistance", "5 ATM", 17 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 108, "Weight", "33 grams (excluding strap)", 17 });

            // ProductDetailsId = 18 (JBL Tune 720BT - Wireless Over-Ear Headphones) with starting Id = 109
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 109, "Driver Size", "40mm dynamic drivers", 18 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 110, "Battery Life", "Up to 50 hours playback", 18 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 111, "Connectivity", "Bluetooth 5.0", 18 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 112, "Features", "Pure Bass sound, multipoint pairing", 18 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 113, "Weight", "198 grams", 18 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 114, "Frequency Response", "20Hz – 20kHz", 18 });

            // ProductDetailsId = 19 (Lenovo Legion 5 Laptop) with starting Id = 115
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 115, "CPU", "AMD Ryzen 7 5800H", 19 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 116, "GPU", "NVIDIA GeForce RTX 3060 (6GB GDDR6)", 19 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 117, "Memory", "16GB DDR4 RAM (3200MHz)", 19 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 118, "Storage", "512GB NVMe SSD", 19 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 119, "Display", "15.6-inch FHD IPS (1920×1080) 165Hz", 19 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 120, "Battery Life", "Up to 5 hours mixed usage", 19 });

            // ProductDetailsId = 20 (Lenovo LOQ 15IRX9 Gaming) with starting Id = 121
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 121, "CPU", "Intel Core i7-12700H", 20 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 122, "GPU", "NVIDIA GeForce RTX 3070 Ti (8GB)", 20 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 123, "Memory", "16GB DDR5 RAM (4800MHz)", 20 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 124, "Storage", "1TB PCIe NVMe SSD", 20 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 125, "Display", "15.6-inch QHD IPS (2560×1440) 165Hz", 20 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 126, "Battery Life", "Up to 4 hours mixed usage", 20 });

            // ProductDetailsId = 21 (LogiTech Steering Wheel for PS5) with starting Id = 127
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 127, "Rotation Angle", "900° wheel rotation", 21 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 128, "Force Feedback", "Dual belt-pulley system", 21 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 129, "Pedals", "2-pedal set (accelerator, brake)", 21 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 130, "Compatibility", "PS5, PS4, PC (Windows)", 21 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 131, "Connectivity", "USB-C wired", 21 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 132, "Material", "Aluminum wheel rim with rubber grip", 21 });

            // ProductDetailsId = 22 (Samsung Galaxy S25 Ultra) with starting Id = 133
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 133, "Chip", "Exynos 2400 / Snapdragon 8 Gen 3", 22 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 134, "Display", "6.8-inch Dynamic AMOLED 2X (3088×1440) 120Hz", 22 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 135, "Memory", "12GB LPDDR5X RAM", 22 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 136, "Storage", "512GB UFS 4.0", 22 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 137, "Camera", "200MP main, 12MP ultra-wide, 10MP telephoto", 22 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 138, "Battery Life", "5,000mAh with 45W fast charging", 22 });

            // ProductDetailsId = 23 (SAMSUNG Galaxy Watch Ultra Smartwatch) with starting Id = 139
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 139, "Display", "1.4-inch AMOLED (450×450)", 23 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 140, "Chip", "Exynos W930", 23 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 141, "Sensors", "GPS, heart rate, SpO₂, barometer", 23 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 142, "Battery Life", "Up to 80 hours mixed use", 23 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 143, "Water Resistance", "5 ATM", 23 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 144, "Connectivity", "Bluetooth 5.2, Wi-Fi, LTE", 23 });

            // ProductDetailsId = 24 (Samsung Galaxy Watch7 Classic Smartwatch) with starting Id = 145
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 145, "Display", "1.36-inch Super AMOLED (450×450)", 24 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 146, "Chip", "Exynos W935", 24 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 147, "Sensors", "EKG, ECG, SpO₂, heart rate", 24 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 148, "Battery Life", "Up to 40 hours mixed use", 24 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 149, "Water Resistance", "5 ATM", 24 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 150, "Connectivity", "Bluetooth 5.3, LTE, Wi-Fi", 24 });

            // ProductDetailsId = 25 (Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch) with starting Id = 151
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 151, "Display", "1.43-inch AMOLED (466×466)", 25 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 152, "Chip", "Kirin A1", 25 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 153, "Sensors", "GPS, heart rate, SpO₂, barometer", 25 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 154, "Battery Life", "Up to 14 days typical use", 25 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 155, "Water Resistance", "5 ATM", 25 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 156, "Connectivity", "Bluetooth 5.2, GPS", 25 });

            // ProductDetailsId = 26 (Sony PS5 PRO) with starting Id = 157
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 157, "CPU", "AMD Zen 2-based CPU (8 cores)", 26 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 158, "GPU", "Custom AMD RDNA 2 (10.28 TFLOPS)", 26 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 159, "Memory", "16GB GDDR6", 26 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 160, "Storage", "825GB Custom SSD", 26 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 161, "Optical Drive", "None (Digital only)", 26 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 162, "Resolution", "8K output support", 26 });

            // ProductDetailsId = 27 (Sony PS5 with 2 Controllers) with starting Id = 163
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 163, "CPU", "AMD Zen 2-based CPU (8 cores)", 27 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 164, "GPU", "Custom AMD RDNA 2 (10.28 TFLOPS)", 27 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 165, "Memory", "16GB GDDR6", 27 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 166, "Storage", "825GB Custom SSD", 27 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 167, "Includes", "Two DualSense wireless controllers", 27 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 168, "Resolution", "8K output support", 27 });

            // ProductDetailsId = 28 (Sony WH-1000XM5) with starting Id = 169
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 169, "Driver Size", "30mm driver units", 28 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 170, "Noise Cancellation", "Dual Noise Sensor technology", 28 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 171, "Battery Life", "Up to 30 hours with ANC", 28 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 172, "Connectivity", "Bluetooth 5.2 with LDAC support", 28 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 173, "Weight", "8.0 ounces (254g)", 28 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 174, "Frequency Response", "4Hz – 40kHz", 28 });

            // ProductDetailsId = 29 (Sony WH-CH720N Noise Canceling Wireless Headphones) with starting Id = 175
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 175, "Driver Size", "30mm neodymium drivers", 29 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 176, "Noise Cancellation", "Digital Noise Cancelling", 29 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 177, "Battery Life", "Up to 35 hours with ANC", 29 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 178, "Connectivity", "Bluetooth 5.0", 29 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 179, "Weight", "7.6 ounces (215g)", 29 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 180, "Features", "Hands-free calling, swift pairing", 29 });

            // ProductDetailsId = 30 (SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard) with starting Id = 181
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 181, "Switch Type", "OmniPoint Adjustable Mechanical Switches", 30 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 182, "Connectivity", "2.4GHz wireless, Bluetooth 5.0, USB-C wired", 30 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 183, "Key Rollover", "N-Key Rollover", 30 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 184, "RGB Backlighting", "Per-key RGB with PrismSync", 30 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 185, "Battery Life", "Up to 40 hours (wireless)", 30 });
            migrationBuilder.InsertData(
                table: "ProductTraits",
                columns: new[] { "Id", "TraitName", "Description", "ProductDetailsId" },
                values: new object[] { 186, "Weight", "2.9 pounds (1.32 kg)", 30 });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int id = 1; id <= 186; id++)
            {
                migrationBuilder.DeleteData(
                    table: "ProductTraits",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }
    }
}
