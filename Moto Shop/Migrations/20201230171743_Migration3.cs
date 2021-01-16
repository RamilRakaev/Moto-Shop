using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotoShopId",
                table: "MotoShopItems",
                newName: "ShopBasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopBasketId",
                table: "MotoShopItems",
                newName: "MotoShopId");
        }
    }
}
