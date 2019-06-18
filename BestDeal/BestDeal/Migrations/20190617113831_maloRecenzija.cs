using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class maloRecenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TekstRecenzije",
                table: "Recenzija",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "IdRecenzije", "BatteryLifeRating", "DesignRating", "IdArtikla", "OverallRating", "PerformanceRating", "TekstRecenzije" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 1, 1.0, 0.0, "Ne valja ništa artikal" },
                    { 2, 0.0, 0.0, 1, 2.0, 0.0, "Ne valja ništa artikal vala" },
                    { 3, 0.0, 0.0, 2, 3.0, 0.0, "Nije loš, ali mu baterija kratko traje" },
                    { 4, 0.0, 0.0, 2, 4.0, 0.0, "Uglavnom sam zadovoljan,međutim malo memorije dolazi uz njega" },
                    { 5, 0.0, 0.0, 3, 3.0, 0.0, "Prevelika cijena u odnosu na performanse" },
                    { 6, 0.0, 0.0, 5, 4.0, 0.0, "Prilicno dobar laptop, sve igrica vrti na visokoj kvaliteti" },
                    { 7, 0.0, 0.0, 2, 2.0, 0.0, "Nije ispunilo moja očekivanja" },
                    { 8, 0.0, 0.0, 6, 5.0, 0.0, "Ma vrh, šta drugo reći" },
                    { 9, 0.0, 0.0, 3, 1.0, 0.0, "Preskupo" },
                    { 10, 0.0, 0.0, 13, 5.0, 0.0, "Odlična kamera, kao i performanse i baterija, prezadovoljan" },
                    { 11, 0.0, 0.0, 19, 5.0, 0.0, "Vrhunske perfomanse pri pristupačnoj cijeni, sve preporuke" },
                    { 12, 0.0, 0.0, 24, 4.0, 0.0, "Odličan gejming računar" },
                    { 13, 0.0, 0.0, 30, 3.0, 0.0, "Nije loš miš, ali dizajn ima mane" },
                    { 14, 0.0, 0.0, 21, 4.0, 0.0, "Prilično dobar desktop replacement" },
                    { 15, 0.0, 0.0, 29, 3.0, 0.0, "Solidne slušalice ali kvaliteta zvuka pri jačoj glasnoći je loša" },
                    { 16, 0.0, 0.0, 31, 5.0, 0.0, "Odlična brzina ove kartica omogućava da brzo prebacujem veće fajlove i video sadržaje" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "TekstRecenzije",
                table: "Recenzija");
        }
    }
}
