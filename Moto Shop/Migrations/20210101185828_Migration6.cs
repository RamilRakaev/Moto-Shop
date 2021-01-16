using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Moto_ProductId",
                table: "OrdersDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails");

            migrationBuilder.RenameColumn(
                name: "HomeAdress",
                table: "Orders",
                newName: "DeliveryAdress");

            migrationBuilder.AddColumn<int>(
                name: "MotoIdId",
                table: "OrdersDetails",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Delivery",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Moto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_MotoIdId",
                table: "OrdersDetails",
                column: "MotoIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Moto_MotoIdId",
                table: "OrdersDetails",
                column: "MotoIdId",
                principalTable: "Moto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Moto_MotoIdId",
                table: "OrdersDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrdersDetails_MotoIdId",
                table: "OrdersDetails");

            migrationBuilder.DropColumn(
                name: "MotoIdId",
                table: "OrdersDetails");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Moto");

            migrationBuilder.RenameColumn(
                name: "DeliveryAdress",
                table: "Orders",
                newName: "HomeAdress");

            migrationBuilder.AlterColumn<bool>(
                name: "Delivery",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Moto_ProductId",
                table: "OrdersDetails",
                column: "ProductId",
                principalTable: "Moto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
