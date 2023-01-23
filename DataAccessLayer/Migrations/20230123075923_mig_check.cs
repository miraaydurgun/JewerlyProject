using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheckOutid",
                table: "Shop_Singles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CheckOuts",
                columns: table => new
                {
                    CheckOutid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COName = table.Column<int>(type: "int", nullable: false),
                    COPhone = table.Column<int>(type: "int", nullable: false),
                    COCountry = table.Column<int>(type: "int", nullable: false),
                    COCity = table.Column<int>(type: "int", nullable: false),
                    COAddressName = table.Column<int>(type: "int", nullable: false),
                    COAddress = table.Column<int>(type: "int", nullable: false),
                    COButton = table.Column<int>(type: "int", nullable: false),
                    COPriceTotal = table.Column<int>(type: "int", nullable: false),
                    Shop_Singleid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOuts", x => x.CheckOutid);
                    table.ForeignKey(
                        name: "FK_CheckOuts_Shop_Singles_Shop_Singleid",
                        column: x => x.Shop_Singleid,
                        principalTable: "Shop_Singles",
                        principalColumn: "Shop_Singleid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Singles_CheckOutid",
                table: "Shop_Singles",
                column: "CheckOutid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckOuts_Shop_Singleid",
                table: "CheckOuts",
                column: "Shop_Singleid");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Singles_CheckOuts_CheckOutid",
                table: "Shop_Singles",
                column: "CheckOutid",
                principalTable: "CheckOuts",
                principalColumn: "CheckOutid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Singles_CheckOuts_CheckOutid",
                table: "Shop_Singles");

            migrationBuilder.DropTable(
                name: "CheckOuts");

            migrationBuilder.DropIndex(
                name: "IX_Shop_Singles_CheckOutid",
                table: "Shop_Singles");

            migrationBuilder.DropColumn(
                name: "CheckOutid",
                table: "Shop_Singles");
        }
    }
}
