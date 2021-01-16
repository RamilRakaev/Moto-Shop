using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MotoShopItems_Moto_MotoId",
                table: "MotoShopItems");

            migrationBuilder.DropIndex(
                name: "IX_MotoShopItems_MotoId",
                table: "MotoShopItems");

            migrationBuilder.AlterColumn<int>(
                name: "MotoId",
                table: "MotoShopItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MotoId",
                table: "MotoShopItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_MotoShopItems_MotoId",
                table: "MotoShopItems",
                column: "MotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MotoShopItems_Moto_MotoId",
                table: "MotoShopItems",
                column: "MotoId",
                principalTable: "Moto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
