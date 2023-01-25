using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Aboutid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Aboutid);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Campaignid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Campaignid);
                });

            migrationBuilder.CreateTable(
                name: "CheckOuts",
                columns: table => new
                {
                    CheckOutid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COPhone = table.Column<int>(type: "int", nullable: false),
                    COCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOuts", x => x.CheckOutid);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contactid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contactid);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Descriptionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Descriptionid);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Informationid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InformationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Informationid);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Loginid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginPassword = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Loginid);
                });

            migrationBuilder.CreateTable(
                name: "NewArrivals",
                columns: table => new
                {
                    NewArrivalid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArrivalImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalBtnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewArrivals", x => x.NewArrivalid);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Reviewid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Reviewid);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Homeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Campaignid = table.Column<int>(type: "int", nullable: false),
                    NewArrivalid = table.Column<int>(type: "int", nullable: false),
                    Reviewid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Homeid);
                    table.ForeignKey(
                        name: "FK_Homes_Campaigns_Campaignid",
                        column: x => x.Campaignid,
                        principalTable: "Campaigns",
                        principalColumn: "Campaignid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homes_NewArrivals_NewArrivalid",
                        column: x => x.NewArrivalid,
                        principalTable: "NewArrivals",
                        principalColumn: "NewArrivalid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homes_Reviews_Reviewid",
                        column: x => x.Reviewid,
                        principalTable: "Reviews",
                        principalColumn: "Reviewid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shop_Singles",
                columns: table => new
                {
                    Shop_Singleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SingleColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleStatus = table.Column<bool>(type: "bit", nullable: false),
                    Descriptionid = table.Column<int>(type: "int", nullable: false),
                    Reviewid = table.Column<int>(type: "int", nullable: false),
                    Informationid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_Singles", x => x.Shop_Singleid);
                    table.ForeignKey(
                        name: "FK_Shop_Singles_Descriptions_Descriptionid",
                        column: x => x.Descriptionid,
                        principalTable: "Descriptions",
                        principalColumn: "Descriptionid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shop_Singles_Informations_Informationid",
                        column: x => x.Informationid,
                        principalTable: "Informations",
                        principalColumn: "Informationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shop_Singles_Reviews_Reviewid",
                        column: x => x.Reviewid,
                        principalTable: "Reviews",
                        principalColumn: "Reviewid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Shopid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopHover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShopPiece = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShopCartIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopStatus = table.Column<bool>(type: "bit", nullable: false),
                    Shop_Singleid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Shopid);
                    table.ForeignKey(
                        name: "FK_Shops_Shop_Singles_Shop_Singleid",
                        column: x => x.Shop_Singleid,
                        principalTable: "Shop_Singles",
                        principalColumn: "Shop_Singleid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homes_Campaignid",
                table: "Homes",
                column: "Campaignid");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_NewArrivalid",
                table: "Homes",
                column: "NewArrivalid");

            migrationBuilder.CreateIndex(
                name: "IX_Homes_Reviewid",
                table: "Homes",
                column: "Reviewid");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Singles_Descriptionid",
                table: "Shop_Singles",
                column: "Descriptionid");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Singles_Informationid",
                table: "Shop_Singles",
                column: "Informationid");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Singles_Reviewid",
                table: "Shop_Singles",
                column: "Reviewid");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_Shop_Singleid",
                table: "Shops",
                column: "Shop_Singleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "CheckOuts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "NewArrivals");

            migrationBuilder.DropTable(
                name: "Shop_Singles");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
