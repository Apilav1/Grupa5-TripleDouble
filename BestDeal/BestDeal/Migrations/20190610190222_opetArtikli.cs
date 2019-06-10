using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class opetArtikli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Artikal",
                columns: table => new
                {
                    IdArtikla = table.Column<int>(nullable: false),
                    TipArtiklaidTipa = table.Column<int>(nullable: false),
                    CijenaArtikla = table.Column<double>(nullable: false),
                    NazivArtikla = table.Column<string>(nullable: false),
                    KratkiOpis = table.Column<string>(nullable: false),
                    DetaljniOpis = table.Column<string>(nullable: true),
                    URLSlike1 = table.Column<string>(nullable: true),
                    URLMaleSlike1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikal", x => x.IdArtikla);
                    table.ForeignKey(
                        name: "FK_Artikal_Tip_TipArtiklaidTipa",
                        column: x => x.TipArtiklaidTipa,
                        principalTable: "Tip",
                        principalColumn: "idTipa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_TipArtiklaidTipa",
                table: "Artikal",
                column: "TipArtiklaidTipa");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "Artikal");

        }
    }
}
