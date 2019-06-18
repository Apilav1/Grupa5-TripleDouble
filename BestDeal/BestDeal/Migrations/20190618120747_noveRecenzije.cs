using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class noveRecenzije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 8,
                column: "KratkiOpis",
                value: "Laptop koji je namjenjen za one koje traže zamjenu za desktop računar!");

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "IdRecenzije", "BatteryLifeRating", "DesignRating", "IdArtikla", "OverallRating", "PerformanceRating", "TekstRecenzije" },
                values: new object[,]
                {
                    { 41, 0.0, 0.0, 31, 4.0, 0.0, "Preporučujem svima ovu memorijsku karticu" },
                    { 40, 0.0, 0.0, 30, 1.0, 0.0, "Bolje pogledajte neki drugi miš, ovaj ne valja ništa" },
                    { 39, 0.0, 0.0, 29, 5.0, 0.0, "Odlične slušalice" },
                    { 38, 0.0, 0.0, 28, 2.0, 0.0, "Nisam zadovoljan ovim slušalicama" },
                    { 37, 0.0, 0.0, 27, 4.0, 0.0, "Odlična tastatura, jedino bi baterija mogla biti malo jača" },
                    { 36, 0.0, 0.0, 26, 5.0, 0.0, "Kompaktan ali i jak račuanr" },
                    { 35, 0.0, 0.0, 25, 5.0, 0.0, "Nova generacija RTX kartice omogućava da igrice rade čak i na rezoluciji od 4K, što je fenomenalno" },
                    { 34, 0.0, 0.0, 24, 4.0, 0.0, "Što se tiče igrica nemam nikakvih zamjerki, sve radi na max opcijama" },
                    { 33, 0.0, 0.0, 23, 5.0, 0.0, "Zadovoljan sam ovim računarom" },
                    { 32, 0.0, 0.0, 22, 3.0, 0.0, "S obzirom kolika mu je cijena nemam šta puno komentarisat" },
                    { 31, 0.0, 0.0, 21, 5.0, 0.0, "Nemam zamjerku" },
                    { 30, 0.0, 0.0, 20, 5.0, 0.0, "Odličan telefon" },
                    { 29, 0.0, 0.0, 19, 5.0, 0.0, "Odličan telefon" },
                    { 28, 0.0, 0.0, 18, 3.0, 0.0, "Osrednja kvaliteta pri pristupačnoj cijeni" },
                    { 27, 0.0, 0.0, 17, 4.0, 0.0, "Još je rano da se upoznamo sa 5g mrežom al sve u svemu nije loš" },
                    { 26, 0.0, 0.0, 16, 1.0, 0.0, "Ne preporučujem ovaj telefon" },
                    { 25, 0.0, 0.0, 15, 5.0, 0.0, "Odlična brzina ove kartica omogućava da brzo prebacujem veće fajlove i video sadržaje" },
                    { 24, 0.0, 0.0, 14, 4.0, 0.0, "Jedina mana je što je preskup" },
                    { 23, 0.0, 0.0, 12, 5.0, 0.0, "Vrhunska kamera, baterija odlična al nam sad preostaje da vidimo kako će se nadogradnje softvera odvijati pošto je Huawei na probnoj listi za ban xD" },
                    { 22, 0.0, 0.0, 11, 3.0, 0.0, "Boja ovog telefona je užasna, a baterija i nije nešto" },
                    { 21, 0.0, 0.0, 10, 5.0, 0.0, "Odličan ekran sa baterijom koja traje cijeli dan" },
                    { 20, 0.0, 0.0, 9, 5.0, 0.0, "Sve pohvale za ovu mašinu, najjača zamjena za desktop" },
                    { 19, 0.0, 0.0, 8, 3.0, 0.0, "Nije loše, performanse su vrhunske ali je mana trajanje baterije te je malo potežak" },
                    { 18, 0.0, 0.0, 7, 4.0, 0.0, "i5 procesor je sasvim dovoljan za svakodnevne stvari, samo je mana sto pri ovoj cijeni nije uključen backlit tastatura" },
                    { 17, 0.0, 0.0, 4, 5.0, 0.0, "Odlična baterija koja izdrži čitav dan, kao i performanse" },
                    { 42, 0.0, 0.0, 32, 5.0, 0.0, "Vrlo lahko se koristi što je po meni i najbitnije" },
                    { 43, 0.0, 0.0, 33, 5.0, 0.0, "Top miš sa velikim brojem programabilnih tipki koji olakšavaju stvari" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "IdRecenzije",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 8,
                column: "KratkiOpis",
                value: "Laptop koji će učiniti svaki zadatak da se sa lahkoćom riješi!");
        }
    }
}
