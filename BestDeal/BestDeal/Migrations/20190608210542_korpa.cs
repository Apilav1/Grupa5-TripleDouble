using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class korpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        
          

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    IdKorpe = table.Column<string>(nullable: false),
                    SlikaKorpe = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AIdArtikla = table.Column<int>(nullable: true),
                    KolicinaArtikla = table.Column<int>(nullable: true),
                    IdKorpe1 = table.Column<string>(nullable: true),
                    IdKomponente = table.Column<int>(nullable: true),
                    KorpaIdKorpe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.IdKorpe);
                    table.ForeignKey(
                        name: "FK_Korpa_Artikal_AIdArtikla",
                        column: x => x.AIdArtikla,
                        principalTable: "Artikal",
                        principalColumn: "IdArtikla",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Korpa_Korpa_KorpaIdKorpe",
                        column: x => x.KorpaIdKorpe,
                        principalTable: "Korpa",
                        principalColumn: "IdKorpe",
                        onDelete: ReferentialAction.Restrict);
                });

           
           

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_AIdArtikla",
                table: "Korpa",
                column: "AIdArtikla");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KorpaIdKorpe",
                table: "Korpa",
                column: "KorpaIdKorpe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korpa");
        }
    }
}
