using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class dobilaINokiaSliku : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 14,
                column: "URLMaleSlike1",
                value: "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6325/6325704cv11d.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 14,
                column: "URLMaleSlike1",
                value: @"https://cdn2.gsmarena.com/vv/bigpic
okia-9-pureview-.jpg");
        }
    }
}
