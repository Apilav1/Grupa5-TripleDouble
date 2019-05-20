using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class hajdeKlase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    IdKorpe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.IdKorpe);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    IdObavijesti = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TekstObavijesti = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.IdObavijesti);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    IdRecenzije = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatteryLifeRating = table.Column<double>(nullable: false),
                    DesignRating = table.Column<double>(nullable: false),
                    PerformanceRating = table.Column<double>(nullable: false),
                    OverallRating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.IdRecenzije);
                });

            migrationBuilder.CreateTable(
                name: "Tip",
                columns: table => new
                {
                    Ime = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip", x => x.Ime);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    IdNarudzbe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OdabraniArtikliIdKorpe = table.Column<int>(nullable: true),
                    DatumVrijemeNarudzbe = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.IdNarudzbe);
                    table.ForeignKey(
                        name: "FK_Narudzba_Korpa_OdabraniArtikliIdKorpe",
                        column: x => x.OdabraniArtikliIdKorpe,
                        principalTable: "Korpa",
                        principalColumn: "IdKorpe",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artikal",
                columns: table => new
                {
                    IdArtikla = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipArtiklaIme = table.Column<string>(nullable: false),
                    CijenaArtikla = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikal", x => x.IdArtikla);
                    table.ForeignKey(
                        name: "FK_Artikal_Tip_TipArtiklaIme",
                        column: x => x.TipArtiklaIme,
                        principalTable: "Tip",
                        principalColumn: "Ime",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_TipArtiklaIme",
                table: "Artikal",
                column: "TipArtiklaIme");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_OdabraniArtikliIdKorpe",
                table: "Narudzba",
                column: "OdabraniArtikliIdKorpe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikal");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Tip");

            migrationBuilder.DropTable(
                name: "Korpa");
        }
    }
}
