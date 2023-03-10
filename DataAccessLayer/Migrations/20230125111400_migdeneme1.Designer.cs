// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230125111400_migdeneme1")]
    partial class migdeneme1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("Aboutid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aboutid");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Campaign", b =>
                {
                    b.Property<int>("Campaignid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CampaignComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Campaignid");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CheckOut", b =>
                {
                    b.Property<int>("CheckOutid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COPhone")
                        .HasColumnType("int");

                    b.HasKey("CheckOutid");

                    b.ToTable("CheckOuts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("Contactid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Contactid");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Description", b =>
                {
                    b.Property<int>("Descriptionid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Descriptionid");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Home", b =>
                {
                    b.Property<int>("Homeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Campaignid")
                        .HasColumnType("int");

                    b.Property<int>("NewArrivalid")
                        .HasColumnType("int");

                    b.Property<int>("Reviewid")
                        .HasColumnType("int");

                    b.Property<string>("SliderComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Homeid");

                    b.HasIndex("Campaignid");

                    b.HasIndex("NewArrivalid");

                    b.HasIndex("Reviewid");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Information", b =>
                {
                    b.Property<int>("Informationid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InformationComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Informationid");

                    b.ToTable("Informations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Login", b =>
                {
                    b.Property<int>("Loginid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoginPassword")
                        .HasColumnType("int");

                    b.HasKey("Loginid");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewArrival", b =>
                {
                    b.Property<int>("NewArrivalid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArrivalBtnTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewArrivalid");

                    b.ToTable("NewArrivals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Review", b =>
                {
                    b.Property<int>("Reviewid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReviewComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReviewStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Reviewid");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shop", b =>
                {
                    b.Property<int>("Shopid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopHover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ShopPiece")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ShopPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ShopStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ShopTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shop_Singleid")
                        .HasColumnType("int");

                    b.HasKey("Shopid");

                    b.HasIndex("Shop_Singleid");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shop_Single", b =>
                {
                    b.Property<int>("Shop_Singleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Descriptionid")
                        .HasColumnType("int");

                    b.Property<int>("Informationid")
                        .HasColumnType("int");

                    b.Property<int>("Reviewid")
                        .HasColumnType("int");

                    b.Property<string>("SingleColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SingleStatus")
                        .HasColumnType("bit");

                    b.HasKey("Shop_Singleid");

                    b.HasIndex("Descriptionid");

                    b.HasIndex("Informationid");

                    b.HasIndex("Reviewid");

                    b.ToTable("Shop_Singles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Home", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Campaign", "Campaign")
                        .WithMany("Homes")
                        .HasForeignKey("Campaignid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.NewArrival", "NewArrival")
                        .WithMany("Homes")
                        .HasForeignKey("NewArrivalid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Review", "Review")
                        .WithMany("Homes")
                        .HasForeignKey("Reviewid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("NewArrival");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shop", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Shop_Single", "Shop_Single")
                        .WithMany("Shops")
                        .HasForeignKey("Shop_Singleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop_Single");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shop_Single", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Description", "Description")
                        .WithMany("Shop_Singles")
                        .HasForeignKey("Descriptionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Information", "Information")
                        .WithMany("Shop_Singles")
                        .HasForeignKey("Informationid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Review", "Review")
                        .WithMany("Shop_Singles")
                        .HasForeignKey("Reviewid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Description");

                    b.Navigation("Information");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.Campaign", b =>
                {
                    b.Navigation("Homes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Description", b =>
                {
                    b.Navigation("Shop_Singles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Information", b =>
                {
                    b.Navigation("Shop_Singles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewArrival", b =>
                {
                    b.Navigation("Homes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Review", b =>
                {
                    b.Navigation("Homes");

                    b.Navigation("Shop_Singles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shop_Single", b =>
                {
                    b.Navigation("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
