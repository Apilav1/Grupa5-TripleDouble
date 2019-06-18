using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class maliUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 25,
                columns: new[] { "OverallRating", "TekstRecenzije" },
                values: new object[] { 3.0, "Ne znam šta da kažem i valja i ne valja" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 25,
                columns: new[] { "OverallRating", "TekstRecenzije" },
                values: new object[] { 5.0, "Odlična brzina ove kartica omogućava da brzo prebacujem veće fajlove i video sadržaje" });
        }
    }
}
