using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class prilagodbaTipa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikal_Tip_TipArtiklaIme",
                table: "Artikal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tip",
                table: "Tip");

            migrationBuilder.DropIndex(
                name: "IX_Artikal_TipArtiklaIme",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "TipArtiklaIme",
                table: "Artikal");

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Tip",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "idTipa",
                table: "Tip",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "TipArtiklaidTipa",
                table: "Artikal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tip",
                table: "Tip",
                column: "idTipa");

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_TipArtiklaidTipa",
                table: "Artikal",
                column: "TipArtiklaidTipa");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikal_Tip_TipArtiklaidTipa",
                table: "Artikal",
                column: "TipArtiklaidTipa",
                principalTable: "Tip",
                principalColumn: "idTipa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikal_Tip_TipArtiklaidTipa",
                table: "Artikal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tip",
                table: "Tip");

            migrationBuilder.DropIndex(
                name: "IX_Artikal_TipArtiklaidTipa",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "idTipa",
                table: "Tip");

            migrationBuilder.DropColumn(
                name: "TipArtiklaidTipa",
                table: "Artikal");

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Tip",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipArtiklaIme",
                table: "Artikal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tip",
                table: "Tip",
                column: "Ime");

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_TipArtiklaIme",
                table: "Artikal",
                column: "TipArtiklaIme");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikal_Tip_TipArtiklaIme",
                table: "Artikal",
                column: "TipArtiklaIme",
                principalTable: "Tip",
                principalColumn: "Ime",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
