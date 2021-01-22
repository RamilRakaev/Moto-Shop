using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clothings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelName = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelName = table.Column<string>(nullable: true),
                    FrontTires = table.Column<string>(nullable: true),
                    RearTires = table.Column<string>(nullable: true),
                    FuelTank = table.Column<byte>(nullable: false),
                    MaxSpeed = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    EngineVolume = table.Column<int>(nullable: false),
                    HorsePower = table.Column<byte>(nullable: false),
                    FuelSupplySystem = table.Column<string>(nullable: true),
                    Cylinders = table.Column<byte>(nullable: false),
                    Ticks = table.Column<byte>(nullable: false),
                    Transmission = table.Column<string>(nullable: true),
                    DriveUnit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MotoId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ShopBasketId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoShopItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Surname = table.Column<string>(maxLength: 25, nullable: false),
                    Number = table.Column<string>(maxLength: 20, nullable: false),
                    EmailAdress = table.Column<string>(maxLength: 25, nullable: false),
                    DeliveryAdress = table.Column<string>(maxLength: 50, nullable: false),
                    Delivery = table.Column<string>(maxLength: 3, nullable: false),
                    OrderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    ModelID = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    LongDesc = table.Column<string>(nullable: true),
                    ShortDesc = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    IsFavorite = table.Column<bool>(nullable: false),
                    Avialable = table.Column<bool>(nullable: false),
                    IsMoto = table.Column<bool>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moto_MotoModels_ModelID",
                        column: x => x.ModelID,
                        principalTable: "MotoModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Moto_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Moto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moto_ModelID",
                table: "Moto",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_OrderId",
                table: "OrdersDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothings");

            migrationBuilder.DropTable(
                name: "MotoShopItems");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "MotoModels");
        }
    }
}
