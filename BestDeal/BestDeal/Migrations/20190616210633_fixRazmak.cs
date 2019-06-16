using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class fixRazmak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 3,
                column: "DetaljniOpis",
                value: @"1.6GHz dual‑core 8th‑generation Intel Core i5 processor Turbo Boost up to 3.6GHz
 Retina display 13.3-inch (diagonal) LED-backlit display with IPS technology; 2560 - by - 1600 native resolution at 227 pixels per inch with support for millions of colors
 8GB 2133MHz LPDDR3 memory
 128GB SSD storage
 Intel UHD Graphics 617 Touch ID
 Force Touch trackpad
 Two Thunderbolt 3 ports
 Backlit Keyboard - US English");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 4,
                column: "DetaljniOpis",
                value: @"Procesor: Intel Core i5-7200 na 2.5GHz 
 RAM: 8GB DDR3 
 SSD: 256GB 
 Grafika: Intel HD Graphics 620 
 Display: 14""FHD IPS LED");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 5,
                column: "DetaljniOpis",
                value: @"CPU Intel Core i7 8550U (1.80 GHz up to 4.00 GHz) 8MB 
 Radna memorija DDR4 8GB
 HDD SSD 256GB 
 VGA Nvidia GTX1050 4GB DDR5 128 bita 
 Ekran 15.6 LED full HD (1920x1080) 
 Webcam, wifi, BT, HDMI, USB 3.0 x 2 
 USB-C, LAN, cardreader, osvjetljena tastatura 
 Windows 10 Pro licenca 64 bita");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 6,
                column: "DetaljniOpis",
                value: @"15,6 inch HD (1366×768) AG 
 Pentium N5000 ( 4M, up to 2.7GHz) 
 4GB DD4 
 1TB HDD (5400 rpm) 
 DVD RW 
 Intel UHD Graphics 
  4-Cell Batt (40Whr) 
 Ubunt Linux 16.04, Ultra Blue");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 8,
                columns: new[] { "DetaljniOpis", "KratkiOpis" },
                values: new object[] { @"Procesor: Intel Core i7 8750H 2.2 GHz (6 Cores) 
 Memorija (RAM): 16 GB DDR4 
 Hard disk: 512 GB, SSD 
 Grafička: Nvidia GeForce GTX 1050 
 Mreža: Wireless, LAN 
 Ostalo: Card Reader, HDMI, USB3.1 , VGA ,Fingerprint", "Laptop koji će učiniti svaki zadatak da se sa lahkoćom riješi!" });

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 9,
                column: "DetaljniOpis",
                value: @"Model procesora: i9-8950HK 2.90GHZ, 8 jezgri 
 RAM: 32 GB 
 SSD kapacitet (GB): 1500GB SSD 
 Proizvođač graf. kartice: NVIDIA RTX 2080 
 Rezolucija: 1920x1080 144Hz refresh rate");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 10,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.4 inches 1440x3040 pixels, 19:9 ratio (~522 ppi density) 
 OS: Android 9.0 (Pie) 
 Procesor: Exynos 9820 (8nm) 
 GPU: Mali-G76 MP12 
 Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only 
 Internal: 1 TB, 12 GB RAM, 128/512 GB, 8 GB RAM 
 Glavna kamera: Triple sensor(12MP, 12MP, 16MP) 
 Prednja kamera: Dual (10MP, 8MP) 
 Baterija: 4100mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 11,
                column: "DetaljniOpis",
                value: @"Rezolucija: 5.8 inches 1125 x 2436 pixels, 19.5:9 ratio (~458 ppi density) 
 OS: iOS 11.1.1, upgradable to iOS 12.3 
 Procesor: Apple A11 Bionic (10 nm) 
 GPU: Apple GPU (three-core graphics) 
 Card slot: No 
 Internal: 64/256 GB, 3 GB RAM 
 Glavna kamera: Dual sensor(12MP, 12MP) 
 Prednja kamera: Dual (7MP, TOF 3D kamera) 
 Baterija: 2716mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 12,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.47 inches 1080 x 2340 pixels, 19.5:9 ratio (~398 ppi density) 
 OS: Android 9.0 (Pie); EMUI 9.1 
 Procesor: HiSilicon Kirin 980 (7 nm) 
 GPU: Mali-G76 MP12 
 Card slot: NM (Nano Memory), up to 256GB (uses shared SIM slot) 
 Internal: 128/256/512 GB, 8 GB RAM or 128 GB, 6 GB RAM 
 Glavna kamera: Quad sensors(40MP, Periscope 8MP, 20MP, TOF 3D kamera) 
 Prednja kamera: Single (32MP) 
 Baterija: 4200mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 13,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.67 inches 1440 x 3120 pixels, 19.5:9 ratio (~516 ppi density) 
 OS: Android 9.0 (Pie); OxygenOS 9.5.7 
 Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) 
 GPU: Adreno 640 
 Card slot: No 
 Internal: 256 GB, 8/12 GB RAM or 128 GB, 6 GB RAM 
 Glavna kamera: Triple sensors(48MP, 8MP, 16MP) 
 Prednja kamera: Motorized pop-up 16 MP 
 Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 14,
                columns: new[] { "DetaljniOpis", "URLMaleSlike1", "URLSlike1" },
                values: new object[] { @"Rezolucija: 5.99 inches 1440 x 2880 pixels, 18:9 ratio (~538 ppi density) 
 OS: Android 9.0 (Pie); Android One 
 Procesor: Qualcomm SDM845 Snapdragon 845 (10 nm) 
 GPU: Adreno 630 
 Card slot: No 
 Internal: 128 GB, 6 GB RAM 
 Glavna kamera: Five sensors(5x 12MP f/1.8) 
 Prednja kamera: 20 MP 
 Baterija: 3320mAh", @"https://cdn2.gsmarena.com/vv/bigpic
okia-9-pureview-.jpg", @"https://cdn2.gsmarena.com/vv/bigpic
okia-9-pureview-.jpg" });

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 15,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) 
 OS: Android 9.0 (Pie) 
 Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) 
 GPU: Adreno 508 
 Card slot: microSD, up to 1 TB (uses shared SIM slot) 
 Internal: 64 GB, 3 GB RAM or 4 GB (for China only) 
 Glavna kamera: Dual (13MP, 5MP) 
 Prednja kamera: 8 MP 
 Baterija: 2870mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 16,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) 
 OS: Android 9.0 (Pie) 
 Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) 
 GPU: Adreno 508 
 Card slot: microSD, up to 1 TB (uses shared SIM slot) 
 Internal: 64 GB, 3 GB RAM or 4 GB (for China only) 
 Glavna kamera: Dual (13MP, 5MP) 
 Prednja kamera: 8 MP 
 Baterija: 2870mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 17,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.4 inches 1440 x 3120 pixels, 19.5:9 ratio (~538 ppi density) 
 OS: Android 9.0 (Pie) 
 Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) 
 GPU: Adreno 640 
 Card slot: microSD, up to 1 TB (dedicated slot)
 Internal: 128 GB, 6 GB RAM 
 Glavna kamera: Triple (12MP, 12MP, 16MP) 
 Prednja kamera:Dual 8 MP, 5 MP 
 Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 18,
                column: "DetaljniOpis",
                value: @"Rezolucija: 5.5 inches 1440 x 2560 pixels, 16:9 ratio (~534 ppi density) 
 OS: Android 7.1 (Nougat), upgradable to Android 9.0 (Pie); Sense UI 
 Procesor: Qualcomm MSM8998 Snapdragon 835 (10 nm) 
 GPU: Adreno 540 
 Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only
 Internal: 128 GB, 6 GB RAM or 64 GB, 4 GB RAM 
 Glavna kamera: Main (12MP f/1.7) 
 Prednja kamera: 16MP f/2.0 
 Baterija: 3000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 19,
                column: "DetaljniOpis",
                value: @"Rezolucija: 6.39 inches 1080 x 2340 pixels, 19.5:9 ratio (~403 ppi density) 
 OS: Android 9.0 (Pie); ZUI 11 
 Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) 
 GPU: Adreno 640 
 Card slot: microSD, up to 1 TB (uses shared SIM slot) 
 Internal: 512 GB, 12 GB RAM or 256 GB, 8 GB RAM or 128 GB, 6/8 GB RAM 
 Glavna kamera: Quad (48MP, 8MP, 16MP, 2MP) 
 Prednja kamera: 32MP f/2.0 
 Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 20,
                column: "DetaljniOpis",
                value: @"System: Intel Core i5-9400f 2.9GHz 6-Core | Intel B360 Chipset | 8GB DDR4 | 120GB SSD | 1TB HDD | Genuine Windows 10 Home 64-bit 
 Graphics: NVIDIA GeForce GTX 1660 6GB Video Card | 1x HDMI | 1x DisplayPort 
 Connectivity: 6 x USB 3.1 | 2 x USB 2.0 | 1x RJ-45 Network Ethernet 10/100/1000 | 802.11AC Wi-Fi | Audio: 7.1 Channel | Gaming ");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 21,
                column: "DetaljniOpis",
                value: @"8th Generation Intel Core i5-8250U Processor 1.6GHz (Up to 3.4GHz); Operating System Architecture: 64-bit 
 23.8 inches Full HD (1920 x 1080) Widescreen Edge-to-Edge LED Back-lit Display 
 12GB DDR4 2400MHz Memory & 1TB 5400RPM SATA Hard Drive 802.11ac Wi-Fi, Gigabit Ethernet LAN & Bluetooth 4.2LE");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 22,
                column: "DetaljniOpis",
                value: @"HP 8300 Intel I5 Quad-Core 3.2 GHz Processor 
 8GB RAM, 500GB Hard Drive, DVD Optical Drive 
 Operativni sitem: Windows 10 Professional");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 23,
                column: "DetaljniOpis",
                value: @"8th Generation Intel Core i3-8100 Processor (3.6GHz) 
 8GB DDR4 2666MHz RAM Memory & 16GB Intel Optane Memory 
 1TB 7200RPM SATA Hard Drive & 8X DVD-Writer Double-Layer Drive (DVD-RW) 
 802.11ac WiFi, Gigabit Ethernet LAN & Bluetooth 5.0. Maximum Power Supply Wattage - 300 W 
 1 - USB 3.1 Type C Gen 2 port (up to 10 Gbps), 1 - USB 3.1 Gen 2 Port, 1 - USB 3.1 Gen 1 Port, 4 - USB 2.0 Ports & 2 - HDMI Ports & 1 - VGA Port");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 24,
                column: "DetaljniOpis",
                value: @"Izgrađen je za igre koje traže ozbiljne performanse.Pažljivo dizajniran za nadogradnju.Brza tehnologija koja je spremna za budućnost 
 Maksimalno povećajte kapacitet igranja. Velika snaga obrade sa 2. generacijom AMD Ryzen 7 procesora 
 Sa 16 GB DDR4 RAM-a, ovaj gaming desktop je ugrađen sa brzim memorijama kako bi se osigurala super-pogonska izvedba i intenzivni multitasking 
 Amd Radeon RX580 Grafika sa 4GB GDDR5 memorije za brži, glatkiji gameplay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 3,
                column: "DetaljniOpis",
                value: "1.6GHz dual‑core 8th‑generation Intel Core i5 processor Turbo Boost up to 3.6GHz<br>Retina display 13.3-inch (diagonal) LED-backlit display with IPS technology; 2560 - by - 1600 native resolution at 227 pixels per inch with support for millions of colors<br> 8GB 2133MHz LPDDR3 memory<br> 128GB SSD storage<br> Intel UHD Graphics 617 Touch ID<br> Force Touch trackpad<br> Two Thunderbolt 3 ports, Backlit Keyboard - US English");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 4,
                column: "DetaljniOpis",
                value: "Procesor: Intel Core i5-7200 na 2.5GHz <br> RAM: 8GB DDR3 <br> SSD: 256GB <br> Grafika: Intel HD Graphics 620 <br> Display: 14\"FHD IPS LED");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 5,
                column: "DetaljniOpis",
                value: "CPU Intel Core i7 8550U (1.80 GHz up to 4.00 GHz) 8MB <br> Radna memorija DDR4 8GB<br> HDD SSD 256GB <br> VGA Nvidia GTX1050 4GB DDR5 128 bita <br> Ekran 15.6 LED full HD (1920x1080) <br> Webcam, wifi, BT, HDMI, USB 3.0 x 2 <br> USB-C, LAN, cardreader, osvjetljena tastatura <br> Windows 10 Pro licenca 64 bita");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 6,
                column: "DetaljniOpis",
                value: "15,6 inch HD (1366×768) AG <br> Pentium N5000 ( 4M, up to 2.7GHz) <br> 4GB DD4 <br> 1TB HDD (5400 rpm) <br> DVD RW <br> Intel UHD Graphics <br>  4-Cell Batt (40Whr) <br> Ubunt Linux 16.04, Ultra Blue");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 8,
                columns: new[] { "DetaljniOpis", "KratkiOpis" },
                values: new object[] { "Procesor: Intel Core i7 8750H 2.2 GHz (6 Cores) <br> Memorija (RAM): 16 GB DDR4 <br> Hard disk: 512 GB, SSD <br> Grafička: Nvidia GeForce GTX 1050 <br> Mreža: Wireless, LAN <br> Ostalo: Card Reader, HDMI, USB3.1 , VGA ,Fingerprint", "Laptop koji će nastaviti oduševljavati i nakon nekoliko godina!" });

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 9,
                column: "DetaljniOpis",
                value: "Model procesora: i9-8950HK 2.90GHZ, 8 jezgri <br> RAM: 32 GB <br> SSD kapacitet (GB): 1500GB SSD <br> Proizvođač graf. kartice: NVIDIA RTX 2080 <br> Rezolucija: 1920x1080 144Hz refresh rate");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 10,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.4 inches 1440x3040 pixels, 19:9 ratio (~522 ppi density) <br> OS: Android 9.0 (Pie) <br> Procesor: Exynos 9820 (8nm) <br> GPU: Mali-G76 MP12 <br> Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only <br> Internal: 1 TB, 12 GB RAM, 128/512 GB, 8 GB RAM <br> Glavna kamera: Triple sensor(12MP, 12MP, 16MP) <br> Prednja kamera: Dual (10MP, 8MP) <br> Baterija: 4100mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 11,
                column: "DetaljniOpis",
                value: "Rezolucija: 5.8 inches 1125 x 2436 pixels, 19.5:9 ratio (~458 ppi density) /n OS: iOS 11.1.1, upgradable to iOS 12.3 /n Procesor: Apple A11 Bionic (10 nm) /n GPU: Apple GPU (three-core graphics) /n Card slot: No /n Internal: 64/256 GB, 3 GB RAM /n Glavna kamera: Dual sensor(12MP, 12MP) /n Prednja kamera: Dual (7MP, TOF 3D kamera) /n Baterija: 2716mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 12,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.47 inches 1080 x 2340 pixels, 19.5:9 ratio (~398 ppi density) /n OS: Android 9.0 (Pie); EMUI 9.1 /n Procesor: HiSilicon Kirin 980 (7 nm) /n GPU: Mali-G76 MP12 /n Card slot: NM (Nano Memory), up to 256GB (uses shared SIM slot) /n Internal: 128/256/512 GB, 8 GB RAM or 128 GB, 6 GB RAM /n Glavna kamera: Quad sensors(40MP, Periscope 8MP, 20MP, TOF 3D kamera) /n Prednja kamera: Single (32MP) /n Baterija: 4200mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 13,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.67 inches 1440 x 3120 pixels, 19.5:9 ratio (~516 ppi density) /n OS: Android 9.0 (Pie); OxygenOS 9.5.7 /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: No /n Internal: 256 GB, 8/12 GB RAM or 128 GB, 6 GB RAM /n Glavna kamera: Triple sensors(48MP, 8MP, 16MP) /n Prednja kamera: Motorized pop-up 16 MP /n Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 14,
                columns: new[] { "DetaljniOpis", "URLMaleSlike1", "URLSlike1" },
                values: new object[] { "Rezolucija: 5.99 inches 1440 x 2880 pixels, 18:9 ratio (~538 ppi density) /n OS: Android 9.0 (Pie); Android One /n Procesor: Qualcomm SDM845 Snapdragon 845 (10 nm) /n GPU: Adreno 630 /n Card slot: No /n Internal: 128 GB, 6 GB RAM /n Glavna kamera: Five sensors(5x 12MP f/1.8) /n Prednja kamera: 20 MP /n Baterija: 3320mAh", "https://cdn2.gsmarena.com/vv/bigpic/nokia-9-pureview-.jpg", "https://cdn2.gsmarena.com/vv/bigpic/nokia-9-pureview-.jpg" });

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 15,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) /n GPU: Adreno 508 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 64 GB, 3 GB RAM or 4 GB (for China only) /n Glavna kamera: Dual (13MP, 5MP) /n Prednja kamera: 8 MP /n Baterija: 2870mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 16,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) /n GPU: Adreno 508 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 64 GB, 3 GB RAM or 4 GB (for China only) /n Glavna kamera: Dual (13MP, 5MP) /n Prednja kamera: 8 MP /n Baterija: 2870mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 17,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.4 inches 1440 x 3120 pixels, 19.5:9 ratio (~538 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: microSD, up to 1 TB (dedicated slot)/n Internal: 128 GB, 6 GB RAM /n Glavna kamera: Triple (12MP, 12MP, 16MP) /n Prednja kamera:Dual 8 MP, 5 MP /n Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 18,
                column: "DetaljniOpis",
                value: "Rezolucija: 5.5 inches 1440 x 2560 pixels, 16:9 ratio (~534 ppi density) /n OS: Android 7.1 (Nougat), upgradable to Android 9.0 (Pie); Sense UI /n Procesor: Qualcomm MSM8998 Snapdragon 835 (10 nm) /n GPU: Adreno 540 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only/n Internal: 128 GB, 6 GB RAM or 64 GB, 4 GB RAM /n Glavna kamera: Main (12MP f/1.7) /n Prednja kamera: 16MP f/2.0 /n Baterija: 3000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 19,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.39 inches 1080 x 2340 pixels, 19.5:9 ratio (~403 ppi density) /n OS: Android 9.0 (Pie); ZUI 11 /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 512 GB, 12 GB RAM or 256 GB, 8 GB RAM or 128 GB, 6/8 GB RAM /n Glavna kamera: Quad (48MP, 8MP, 16MP, 2MP) /n Prednja kamera: 32MP f/2.0 /n Baterija: 4000mAh");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 20,
                column: "DetaljniOpis",
                value: "System: Intel Core i5-9400f 2.9GHz 6-Core | Intel B360 Chipset | 8GB DDR4 | 120GB SSD | 1TB HDD | Genuine Windows 10 Home 64-bit /n Graphics: NVIDIA GeForce GTX 1660 6GB Video Card | 1x HDMI | 1x DisplayPort /n Connectivity: 6 x USB 3.1 | 2 x USB 2.0 | 1x RJ-45 Network Ethernet 10/100/1000 | 802.11AC Wi-Fi | Audio: 7.1 Channel | Gaming ");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 21,
                column: "DetaljniOpis",
                value: "8th Generation Intel Core i5-8250U Processor 1.6GHz (Up to 3.4GHz); Operating System Architecture: 64-bit /n 23.8 inches Full HD (1920 x 1080) Widescreen Edge-to-Edge LED Back-lit Display /n 12GB DDR4 2400MHz Memory & 1TB 5400RPM SATA Hard Drive 802.11ac Wi-Fi, Gigabit Ethernet LAN & Bluetooth 4.2LE");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 22,
                column: "DetaljniOpis",
                value: "HP 8300 Intel I5 Quad-Core 3.2 GHz Processor /n 8GB RAM, 500GB Hard Drive, DVD Optical Drive /n Operativni sitem: Windows 10 Professional");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 23,
                column: "DetaljniOpis",
                value: "8th Generation Intel Core i3-8100 Processor (3.6GHz) /n 8GB DDR4 2666MHz RAM Memory & 16GB Intel Optane Memory /n 1TB 7200RPM SATA Hard Drive & 8X DVD-Writer Double-Layer Drive (DVD-RW) /n 802.11ac WiFi, Gigabit Ethernet LAN & Bluetooth 5.0. Maximum Power Supply Wattage - 300 W /n 1 - USB 3.1 Type C Gen 2 port (up to 10 Gbps), 1 - USB 3.1 Gen 2 Port, 1 - USB 3.1 Gen 1 Port, 4 - USB 2.0 Ports & 2 - HDMI Ports & 1 - VGA Port");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 24,
                column: "DetaljniOpis",
                value: "Izgrađen je za igre koje traže ozbiljne performanse.Pažljivo dizajniran za nadogradnju.Brza tehnologija koja je spremna za budućnost /n Maksimalno povećajte kapacitet igranja. Velika snaga obrade sa 2. generacijom AMD Ryzen 7 procesora /n Sa 16 GB DDR4 RAM-a, ovaj gaming desktop je ugrađen sa brzim memorijama kako bi se osigurala super-pogonska izvedba i intenzivni multitasking /n Amd Radeon RX580 Grafika sa 4GB GDDR5 memorije za brži, glatkiji gameplay");
        }
    }
}
