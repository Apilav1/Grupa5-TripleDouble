using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class fixBaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Korpa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AIdArtikla",
                table: "Korpa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdKorpe1",
                table: "Korpa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KolicinaArtikla",
                table: "Korpa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KorpaIdKorpe",
                table: "Korpa",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_AIdArtikla",
                table: "Korpa",
                column: "AIdArtikla");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KorpaIdKorpe",
                table: "Korpa",
                column: "KorpaIdKorpe");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Artikal_AIdArtikla",
                table: "Korpa",
                column: "AIdArtikla",
                principalTable: "Artikal",
                principalColumn: "IdArtikla",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Korpa_KorpaIdKorpe",
                table: "Korpa",
                column: "KorpaIdKorpe",
                principalTable: "Korpa",
                principalColumn: "IdKorpe",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Artikal_AIdArtikla",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Korpa_KorpaIdKorpe",
                table: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_AIdArtikla",
                table: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_KorpaIdKorpe",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "AIdArtikla",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "IdKorpe1",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "KolicinaArtikla",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "KorpaIdKorpe",
                table: "Korpa");

        }

    }
}
