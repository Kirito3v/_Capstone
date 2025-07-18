using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProj.Migrations
{
    /// <inheritdoc />
    public partial class DetailsFeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple 2024 MacBook Air 13-inch Laptop/0.png,Apple 2024 MacBook Air 13-inch Laptop/1.png,Apple 2024 MacBook Air 13-inch Laptop/2.png,Apple 2024 MacBook Air 13-inch Laptop/3.png',
                    Details = 'Apple 2024 MacBook Air 13-inch Laptop with M2 chip, 8-core CPU, 8GB RAM, and 18 hours battery life.'
                WHERE Id = 1;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple 2024 MacBook Pro Laptop/0.png,Apple 2024 MacBook Pro Laptop/1.png,Apple 2024 MacBook Pro Laptop/2.png,Apple 2024 MacBook Pro Laptop/3.png',
                    Details = 'Apple 2024 MacBook Pro with M2 Pro chip, 14-inch Retina display, 16GB RAM, and superior performance.'
                WHERE Id = 2;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple Airpods Max Over Ear Headphone/0.png,Apple Airpods Max Over Ear Headphone/1.png,Apple Airpods Max Over Ear Headphone/2.png,Apple Airpods Max Over Ear Headphone/3.png',
                    Details = 'Apple AirPods Max, premium wireless headphones with active noise cancellation and spatial audio.'
                WHERE Id = 3;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple AirPods Pro (2nd Generation)/0.png,Apple AirPods Pro (2nd Generation)/1.png,Apple AirPods Pro (2nd Generation)/2.png,Apple AirPods Pro (2nd Generation)/3.png',
                    Details = 'Apple AirPods Pro (2nd Gen) with enhanced noise cancellation and longer battery life.'
                WHERE Id = 4;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple iPhone 11 64GB Purple (M05P3)/0.png,Apple iPhone 11 64GB Purple (M05P3)/1.png,Apple iPhone 11 64GB Purple (M05P3)/2.png,Apple iPhone 11 64GB Purple (M05P3)/3.png',
                    Details = 'Apple iPhone 11 with A13 Bionic chip, dual cameras, and 64GB storage in purple.'
                WHERE Id = 5;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple iPhone 12 64GB Black (M02B3)/0.png,Apple iPhone 12 64GB Black (M02B3)/1.png,Apple iPhone 12 64GB Black (M02B3)/2.png,Apple iPhone 12 64GB Black (M02B3)/3.png',
                    Details = 'Apple iPhone 12 with A14 Bionic chip, OLED display, and 64GB storage in black.'
                WHERE Id = 6;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple IPhone 16 Plus/0.png,Apple IPhone 16 Plus/1.png,Apple IPhone 16 Plus/2.png,Apple IPhone 16 Plus/3.png',
                    Details = 'Apple iPhone 16 Plus featuring advanced camera systems and powerful A18 chip.'
                WHERE Id = 7;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple iPhone 16 ProMax/0.png,Apple iPhone 16 ProMax/1.png,Apple iPhone 16 ProMax/2.png,Apple iPhone 16 ProMax/3.png',
                    Details = 'Apple iPhone 16 ProMax with superior display, triple cameras, and latest iOS.'
                WHERE Id = 8;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple iPhone SE 128GB Red (M03R3)/0.png,Apple iPhone SE 128GB Red (M03R3)/1.png,Apple iPhone SE 128GB Red (M03R3)/2.png,Apple iPhone SE 128GB Red (M03R3)/3.png',
                    Details = 'Apple iPhone SE with A15 Bionic chip, 128GB storage, and vibrant red finish.'
                WHERE Id = 9;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple iPhone X 256GB Silver (M04S3)/0.png,Apple iPhone X 256GB Silver (M04S3)/1.png,Apple iPhone X 256GB Silver (M04S3)/2.png,Apple iPhone X 256GB Silver (M04S3)/3.png',
                    Details = 'Apple iPhone X with 256GB storage, Face ID, and stunning silver finish.'
                WHERE Id = 10;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple Macbook Air 2020 Model/0.png,Apple Macbook Air 2020 Model/1.png,Apple Macbook Air 2020 Model/2.png,Apple Macbook Air 2020 Model/3.png',
                    Details = 'Apple MacBook Air 2020 with M1 chip, 13-inch Retina display, and lightweight design.'
                WHERE Id = 11;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple Watch SE (2nd Gen)/0.png,Apple Watch SE (2nd Gen)/1.png,Apple Watch SE (2nd Gen)/2.png,Apple Watch SE (2nd Gen)/3.png',
                    Details = 'Apple Watch SE 2nd Gen with fitness tracking and enhanced performance.'
                WHERE Id = 12;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Apple Watch Ultra 2 [GPS + Cellular 49mm]/0.png,Apple Watch Ultra 2 [GPS + Cellular 49mm]/1.png,Apple Watch Ultra 2 [GPS + Cellular 49mm]/2.png,Apple Watch Ultra 2 [GPS + Cellular 49mm]/3.png',
                    Details = 'Apple Watch Ultra 2 with GPS, Cellular, 49mm titanium case, and rugged design.'
                WHERE Id = 13;

                UPDATE ProductsDetails SET
                    ImagePaths = 'DualSense Edge PS5 Controller/0.png,DualSense Edge PS5 Controller/1.png,DualSense Edge PS5 Controller/2.png,DualSense Edge PS5 Controller/3.png',
                    Details = 'DualSense Edge PS5 Controller with customizable controls and improved ergonomics.'
                WHERE Id = 14;

                UPDATE ProductsDetails SET
                    ImagePaths = 'DualSense PS5 Controller/0.png,DualSense PS5 Controller/1.png,DualSense PS5 Controller/2.png,DualSense PS5 Controller/3.png',
                    Details = 'Standard DualSense PS5 Controller featuring haptic feedback and adaptive triggers.'
                WHERE Id = 15;

                UPDATE ProductsDetails SET
                    ImagePaths = 'HP Victus FA0033DX/0.png,HP Victus FA0033DX/1.png,HP Victus FA0033DX/2.png,HP Victus FA0033DX/3.png',
                    Details = 'HP Victus FA0033DX gaming laptop with AMD Ryzen CPU and NVIDIA RTX GPU.'
                WHERE Id = 16;

                UPDATE ProductsDetails SET
                    ImagePaths = 'HUAWEI Watch FIT 3/0.png,HUAWEI Watch FIT 3/1.png,HUAWEI Watch FIT 3/2.png,HUAWEI Watch FIT 3/3.png',
                    Details = 'HUAWEI Watch FIT 3 with health monitoring and vibrant AMOLED display.'
                WHERE Id = 17;

                UPDATE ProductsDetails SET
                    ImagePaths = 'JBL Tune 720BT - Wireless Over-Ear Headphones/0.png,JBL Tune 720BT - Wireless Over-Ear Headphones/1.png,JBL Tune 720BT - Wireless Over-Ear Headphones/2.png,JBL Tune 720BT - Wireless Over-Ear Headphones/3.png',
                    Details = 'JBL Tune 720BT wireless headphones with Pure Bass sound and long battery life.'
                WHERE Id = 18;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Lenovo Legion 5 Laptop/0.png,Lenovo Legion 5 Laptop/1.png,Lenovo Legion 5 Laptop/2.png,Lenovo Legion 5 Laptop/3.png',
                    Details = 'Lenovo Legion 5 gaming laptop with AMD Ryzen and NVIDIA RTX graphics.'
                WHERE Id = 19;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Lenovo LOQ 15IRX9 Gaming/0.png,Lenovo LOQ 15IRX9 Gaming/1.png,Lenovo LOQ 15IRX9 Gaming/2.png,Lenovo LOQ 15IRX9 Gaming/3.png',
                    Details = 'Lenovo LOQ 15IRX9 gaming laptop with powerful CPU and high-refresh-rate display.'
                WHERE Id = 20;

                UPDATE ProductsDetails SET
                    ImagePaths = 'LogiTech Steering Wheel for PS5/0.png,LogiTech Steering Wheel for PS5/1.png,LogiTech Steering Wheel for PS5/2.png,LogiTech Steering Wheel for PS5/3.png',
                    Details = 'LogiTech Steering Wheel for PS5 with force feedback and responsive controls.'
                WHERE Id = 21;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Samsung Galaxy S25 Ultra/0.png,Samsung Galaxy S25 Ultra/1.png,Samsung Galaxy S25 Ultra/2.png,Samsung Galaxy S25 Ultra/3.png',
                    Details = 'Samsung Galaxy S25 Ultra with advanced camera system and large AMOLED display.'
                WHERE Id = 22;

                UPDATE ProductsDetails SET
                    ImagePaths = 'SAMSUNG Galaxy Watch Ultra Smartwatch/0.png,SAMSUNG Galaxy Watch Ultra Smartwatch/1.png,SAMSUNG Galaxy Watch Ultra Smartwatch/2.png,SAMSUNG Galaxy Watch Ultra Smartwatch/3.png',
                    Details = 'Samsung Galaxy Watch Ultra with rugged design and health tracking features.'
                WHERE Id = 23;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Samsung Galaxy Watch7 Classic Smartwatch/0.png,Samsung Galaxy Watch7 Classic Smartwatch/1.png,Samsung Galaxy Watch7 Classic Smartwatch/2.png,Samsung Galaxy Watch7 Classic Smartwatch/3.png',
                    Details = 'Samsung Galaxy Watch7 Classic with elegant design and comprehensive health sensors.'
                WHERE Id = 24;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch/0.png,Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch/1.png,Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch/2.png,Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch/3.png',
                    Details = 'Sony HUAWEI Watch GT 5 Pro 46 mm with long battery life and fitness features.'
                WHERE Id = 25;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Sony PS5 PRO/0.png,Sony PS5 PRO/1.png,Sony PS5 PRO/2.png,Sony PS5 PRO/3.png',
                    Details = 'Sony PS5 PRO console with upgraded performance and enhanced graphics.'
                WHERE Id = 26;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Sony PS5 with 2 Controllers/0.png,Sony PS5 with 2 Controllers/1.png,Sony PS5 with 2 Controllers/2.png,Sony PS5 with 2 Controllers/3.png',
                    Details = 'Sony PS5 bundle including console and two wireless controllers.'
                WHERE Id = 27;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Sony WH-1000XM5/0.png,Sony WH-1000XM5/1.png,Sony WH-1000XM5/2.png,Sony WH-1000XM5/3.png',
                    Details = 'Sony WH-1000XM5 noise-cancelling wireless headphones with superior sound.'
                WHERE Id = 28;

                UPDATE ProductsDetails SET
                    ImagePaths = 'Sony WH-CH720N Noise Canceling Wireless Headphones/0.png,Sony WH-CH720N Noise Canceling Wireless Headphones/1.png,Sony WH-CH720N Noise Canceling Wireless Headphones/2.png,Sony WH-CH720N Noise Canceling Wireless Headphones/3.png',
                    Details = 'Sony WH-CH720N wireless headphones with noise cancelling and long battery life.'
                WHERE Id = 29;

                UPDATE ProductsDetails SET
                    ImagePaths = 'SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard/0.png,SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard/1.png,SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard/2.png,SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard/3.png',
                    Details = 'SteelSeries Apex Pro TKL wireless gaming keyboard with adjustable mechanical switches.'
                WHERE Id = 30;
            "); 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert ImagePaths to old format with semicolons
            migrationBuilder.Sql(@"
                UPDATE ProductsDetails
                SET ImagePaths = REPLACE(ImagePaths, ',', ';')
            ");

            // Restore old generic details text
            migrationBuilder.Sql(@"
                UPDATE ProductsDetails
                SET Details = 'Details for ' + 
                    CASE Id
                        WHEN 1 THEN 'Apple 2024 MacBook Air 13-inch Laptop'
                        WHEN 2 THEN 'Apple 2024 MacBook Pro Laptop'
                        WHEN 3 THEN 'Apple Airpods Max Over Ear Headphone'
                        WHEN 4 THEN 'Apple AirPods Pro (2nd Generation)'
                        WHEN 5 THEN 'Apple iPhone 11 64GB Purple (M05P3)'
                        WHEN 6 THEN 'Apple iPhone 12 64GB Black (M02B3)'
                        WHEN 7 THEN 'Apple IPhone 16 Plus'
                        WHEN 8 THEN 'Apple iPhone 16 ProMax'
                        WHEN 9 THEN 'Apple iPhone SE 128GB Red (M03R3)'
                        WHEN 10 THEN 'Apple iPhone X 256GB Silver (M04S3)'
                        WHEN 11 THEN 'Apple Macbook Air 2020 Model'
                        WHEN 12 THEN 'Apple Watch SE (2nd Gen)'
                        WHEN 13 THEN 'Apple Watch Ultra 2 [GPS + Cellular 49mm]'
                        WHEN 14 THEN 'DualSense Edge PS5 Controller'
                        WHEN 15 THEN 'DualSense PS5 Controller'
                        WHEN 16 THEN 'HP Victus FA0033DX'
                        WHEN 17 THEN 'HUAWEI Watch FIT 3'
                        WHEN 18 THEN 'JBL Tune 720BT - Wireless Over-Ear Headphones'
                        WHEN 19 THEN 'Lenovo Legion 5 Laptop'
                        WHEN 20 THEN 'Lenovo LOQ 15IRX9 Gaming'
                        WHEN 21 THEN 'LogiTech Steering Wheel for PS5'
                        WHEN 22 THEN 'Samsung Galaxy S25 Ultra'
                        WHEN 23 THEN 'SAMSUNG Galaxy Watch Ultra Smartwatch'
                        WHEN 24 THEN 'Samsung Galaxy Watch7 Classic Smartwatch'
                        WHEN 25 THEN 'Sony HUAWEI Watch GT 5 Pro 46 mm Smartwatch'
                        WHEN 26 THEN 'Sony PS5 PRO'
                        WHEN 27 THEN 'Sony PS5 with 2 Controllers'
                        WHEN 28 THEN 'Sony WH-1000XM5'
                        WHEN 29 THEN 'Sony WH-CH720N Noise Canceling Wireless Headphones'
                        WHEN 30 THEN 'SteelSeries Apex Pro TKL Wireless HyperMagnetic Gaming Keyboard'
                        ELSE 'Details for unknown product'
                    END
            ");
        }

    }
}
