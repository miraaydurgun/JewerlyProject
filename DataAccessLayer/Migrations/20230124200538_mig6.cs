using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "COAddressName",
                table: "CheckOuts");

            migrationBuilder.DropColumn(
                name: "COButton",
                table: "CheckOuts");

            migrationBuilder.DropColumn(
                name: "COCountry",
                table: "CheckOuts");

            migrationBuilder.DropColumn(
                name: "COPriceTotal",
                table: "CheckOuts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "COAddressName",
                table: "CheckOuts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COButton",
                table: "CheckOuts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COCountry",
                table: "CheckOuts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "COPriceTotal",
                table: "CheckOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
