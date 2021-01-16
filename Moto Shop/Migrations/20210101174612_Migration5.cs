using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HomeAdress",
                table: "Orders",
                newName: "DeliveryAdress");

            migrationBuilder.AlterColumn<string>(
                name: "Delivery",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
