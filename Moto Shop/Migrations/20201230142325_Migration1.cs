using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moto_Shop.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotoModel",
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
                    table.PrimaryKey("PK_MotoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ModelID = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    LongDesc = table.Column<string>(nullable: true),
                    ShortDesc = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    IsFavorite = table.Column<bool>(nullable: false),
                    Avialable = table.Column<bool>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moto_MotoModel_ModelID",
                        column: x => x.ModelID,
                        principalTable: "MotoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moto_ModelID",
                table: "Moto",
                column: "ModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "MotoModel");
        }
    }
}
