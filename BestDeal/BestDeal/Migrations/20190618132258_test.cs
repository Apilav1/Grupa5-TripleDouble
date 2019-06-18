using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "~/lib/slike/1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikal",
                keyColumn: "IdArtikla",
                keyValue: 1,
                column: "URLMaleSlike1",
                value: "https://static.toiimg.com/photo/60104728/HP-15-BS542TU-2EY84PA-Laptop-Core-i3-6th-Gen4-GB1-TBDOS.jpg");
        }
    }
}
