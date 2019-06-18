using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class opetTeSlike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "slike/1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "../wwwroot/lib/slike/1.jpg");
        }
    }
}
