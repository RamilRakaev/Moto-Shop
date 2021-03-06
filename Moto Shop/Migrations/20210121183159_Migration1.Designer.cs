﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moto_Shop.Data;

namespace Moto_Shop.Migrations
{
    [DbContext(typeof(MotoDBContext))]
    [Migration("20210121183159_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moto_Shop.Data.Models.Equipment.Clothing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("ModelName");

                    b.Property<string>("Species");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Clothings");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.ModelMotorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<byte>("Cylinders");

                    b.Property<string>("DriveUnit");

                    b.Property<int>("EngineVolume");

                    b.Property<string>("FrontTires");

                    b.Property<string>("FuelSupplySystem");

                    b.Property<byte>("FuelTank");

                    b.Property<byte>("HorsePower");

                    b.Property<int>("MaxSpeed");

                    b.Property<string>("ModelName");

                    b.Property<string>("RearTires");

                    b.Property<byte>("Ticks");

                    b.Property<string>("Transmission");

                    b.HasKey("Id");

                    b.ToTable("MotoModels");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.MotoShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MotoId");

                    b.Property<int>("Price");

                    b.Property<string>("ShopBasketId");

                    b.HasKey("Id");

                    b.ToTable("MotoShopItems");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Delivery")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("DeliveryAdress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("OrderTime");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<long>("Price");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersDetails");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Avialable");

                    b.Property<string>("Color");

                    b.Property<string>("Image");

                    b.Property<bool>("IsFavorite");

                    b.Property<bool>("IsMoto");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Manufacturer");

                    b.Property<int>("Mileage");

                    b.Property<int>("ModelID");

                    b.Property<string>("ModelName");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDesc");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.HasIndex("ModelID");

                    b.ToTable("Moto");
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.OrderDetails", b =>
                {
                    b.HasOne("Moto_Shop.Data.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Moto_Shop.Data.Models.Product", "MotoId")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Moto_Shop.Data.Models.Product", b =>
                {
                    b.HasOne("Moto_Shop.Data.Models.ModelMotorcycle", "Model")
                        .WithMany("Product")
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
