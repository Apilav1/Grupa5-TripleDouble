using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BestDeal.Migrations
{
    public partial class azuriranjeOpisaArtikala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 3,
                column: "DetaljniOpis",
                value: "1.6GHz dual‑core 8th‑generation Intel Core i5 processor Turbo Boost up to 3.6GHz " + Environment.NewLine + "Retina display 13.3-inch (diagonal) LED-backlit display with IPS technology; 2560 - by - 1600 native resolution at 227 pixels per inch with support for millions of colors<br> 8GB 2133MHz LPDDR3 memory<br> 128GB SSD storage<br> Intel UHD Graphics 617 Touch ID<br> Force Touch trackpad<br> Two Thunderbolt 3 ports, Backlit Keyboard - US English");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 3,
                column: "DetaljniOpis",
                value: "1.6GHz dual‑core 8th‑generation Intel Core i5 processor Turbo Boost up to 3.6GHz/n Retina display 13.3-inch (diagonal) LED-backlit display with IPS technology; 2560 - by - 1600 native resolution at 227 pixels per inch with support for millions of colors/n 8GB 2133MHz LPDDR3 memory/n 128GB SSD storage/n Intel UHD Graphics 617 Touch ID/n Force Touch trackpad/n Two Thunderbolt 3 ports/n Backlit Keyboard - US English");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 4,
                column: "DetaljniOpis",
                value: "Procesor: Intel Core i5-7200 na 2.5GHz /n RAM: 8GB DDR3 /n SSD: 256GB /n Grafika: Intel HD Graphics 620 /n Display: 14\"FHD IPS LED");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 5,
                column: "DetaljniOpis",
                value: "CPU Intel Core i7 8550U (1.80 GHz up to 4.00 GHz) 8MB /n Radna memorija DDR4 8GB/n HDD SSD 256GB /n VGA Nvidia GTX1050 4GB DDR5 128 bita /n Ekran 15.6 LED full HD (1920x1080) /n Webcam, wifi, BT, HDMI, USB 3.0 x 2 /n USB-C, LAN, cardreader, osvjetljena tastatura /n Windows 10 Pro licenca 64 bita");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 6,
                column: "DetaljniOpis",
                value: "15,6 inch HD (1366×768) AG /n Pentium N5000 ( 4M, up to 2.7GHz) /n 4GB DD4 /n 1TB HDD (5400 rpm) /n DVD RW /n Intel UHD Graphics /n  4-Cell Batt (40Whr) /n Ubunt Linux 16.04, Ultra Blue");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 8,
                columns: new[] { "DetaljniOpis", "KratkiOpis" },
                values: new object[] { "Procesor: Intel Core i7 8750H 2.2 GHz (6 Cores) /n Memorija (RAM): 16 GB DDR4 /n Hard disk: 512 GB, SSD /n Grafička: Nvidia GeForce GTX 1050 /n Mreža: Wireless, LAN /n Ostalo: Card Reader, HDMI, USB3.1 , VGA ,Fingerprint", "Laptop koji će učiniti svaki zadatak da se sa lahkoćom riješi!" });

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 9,
                column: "DetaljniOpis",
                value: "Model procesora: i9-8950HK 2.90GHZ, 8 jezgri /n RAM: 32 GB /n SSD kapacitet (GB): 1500GB SSD /n Proizvođač graf. kartice: NVIDIA RTX 2080 /n Rezolucija: 1920x1080 144Hz refresh rate");

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 10,
                column: "DetaljniOpis",
                value: "Rezolucija: 6.4 inches 1440x3040 pixels, 19:9 ratio (~522 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Exynos 9820 (8nm) /n GPU: Mali-G76 MP12 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only /n Internal: 1 TB, 12 GB RAM, 128/512 GB, 8 GB RAM /n Glavna kamera: Triple sensor(12MP, 12MP, 16MP) /n Prednja kamera: Dual (10MP, 8MP) /n Baterija: 4100mAh");
        }
    }
}
