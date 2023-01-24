using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckOuts_Shop_Singles_Shop_Singleid",
                table: "CheckOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Singles_CheckOuts_CheckOutid",
                table: "Shop_Singles");

            migrationBuilder.DropIndex(
                name: "IX_Shop_Singles_CheckOutid",
                table: "Shop_Singles");

            migrationBuilder.DropIndex(
                name: "IX_CheckOuts_Shop_Singleid",
                table: "CheckOuts");

            migrationBuilder.DropColumn(
                name: "CheckOutid",
                table: "Shop_Singles");

            migrationBuilder.DropColumn(
                name: "Shop_Singleid",
                table: "CheckOuts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheckOutid",
                table: "Shop_Singles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Shop_Singleid",
                table: "CheckOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Singles_CheckOutid",
                table: "Shop_Singles",
                column: "CheckOutid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckOuts_Shop_Singleid",
                table: "CheckOuts",
                column: "Shop_Singleid");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOuts_Shop_Singles_Shop_Singleid",
                table: "CheckOuts",
                column: "Shop_Singleid",
                principalTable: "Shop_Singles",
                principalColumn: "Shop_Singleid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Singles_CheckOuts_CheckOutid",
                table: "Shop_Singles",
                column: "CheckOutid",
                principalTable: "CheckOuts",
                principalColumn: "CheckOutid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
