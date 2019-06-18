using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class josRecenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "IdRecenzije", "BatteryLifeRating", "DesignRating", "IdArtikla", "OverallRating", "PerformanceRating", "TekstRecenzije" },
                values: new object[] { 44, 0.0, 0.0, 2, 5.0, 0.0, "S obzirom na cijenu vrlo solidan laptop" });

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "IdRecenzije", "BatteryLifeRating", "DesignRating", "IdArtikla", "OverallRating", "PerformanceRating", "TekstRecenzije" },
                values: new object[] { 45, 0.0, 0.0, 2, 4.0, 0.0, "Cijena odlična ali komponente su mogle biti novije" });

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "IdRecenzije", "BatteryLifeRating", "DesignRating", "IdArtikla", "OverallRating", "PerformanceRating", "TekstRecenzije" },
                values: new object[] { 46, 0.0, 0.0, 2, 3.0, 0.0, "Tipičan laptop za prosječnog korisnika, nije loš" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 46);
        }
    }
}
