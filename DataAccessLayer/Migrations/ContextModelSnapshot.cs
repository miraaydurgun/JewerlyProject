﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aboutid");

                    b.ToTable("Abouts");
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

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("Contactid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactButton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactText")
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

                    b.Property<bool>("ReviewMailStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ReviewName")
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
