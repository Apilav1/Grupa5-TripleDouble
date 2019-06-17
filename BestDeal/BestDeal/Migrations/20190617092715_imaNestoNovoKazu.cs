using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class imaNestoNovoKazu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdArtikla",
                table: "Recenzija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_IdArtikla",
                table: "Recenzija",
                column: "IdArtikla");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_Artikal_IdArtikla",
                table: "Recenzija",
                column: "IdArtikla",
                principalTable: "Artikal",
                principalColumn: "IdArtikla",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_Artikal_IdArtikla",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_IdArtikla",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "IdArtikla",
                table: "Recenzija");
        }
    }
}
