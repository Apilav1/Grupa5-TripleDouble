using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class pls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                 name: "AspNetUsers",
                 newName: "IdentityUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
