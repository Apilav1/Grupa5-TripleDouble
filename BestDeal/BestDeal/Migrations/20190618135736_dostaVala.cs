using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class dostaVala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "https://images-na.ssl-images-amazon.com/images/I/81iq991JMEL._SL1500_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "slike/1.jpg");
        }
    }
}
