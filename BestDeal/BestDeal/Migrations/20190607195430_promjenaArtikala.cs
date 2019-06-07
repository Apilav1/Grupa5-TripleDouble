using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class promjenaArtikala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Tip",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "DetaljniOpis",
                table: "Artikal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KratkiOpis",
                table: "Artikal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NazivArtikla",
                table: "Artikal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "URLMaleSlike1",
                table: "Artikal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URLSlike1",
                table: "Artikal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetaljniOpis",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "KratkiOpis",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "NazivArtikla",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "URLMaleSlike1",
                table: "Artikal");

            migrationBuilder.DropColumn(
                name: "URLSlike1",
                table: "Artikal");

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Tip",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
