﻿// <auto-generated />
using System;
using BicycleShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BicycleShop.Migrations
{
    [DbContext(typeof(BicycleContext))]
    [Migration("20210411001010_AddCustmr")]
    partial class AddCustmr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BicycleShop.Models.Color", b =>
                {
                    b.Property<int>("Colors_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Colors_ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("BicycleShop.Models.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BicycleShop.Models.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Costumer_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Order_ID");

                    b.HasIndex("Costumer_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BicycleShop.Models.Product", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BicycleDesign")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Colors_ID")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfTires")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("TireSize")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Product_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BicycleShop.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductOrder_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Colors_ID")
                        .HasColumnType("int");

                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Order_ID1")
                        .HasColumnType("int");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int?>("Product_id1")
                        .HasColumnType("int");

                    b.HasKey("ProductOrder_Id");

                    b.HasIndex("Colors_ID");

                    b.HasIndex("Order_ID1");

                    b.HasIndex("Product_id1");

                    b.ToTable("productOrders");
                });

            modelBuilder.Entity("BicycleShop.Models.Order", b =>
                {
                    b.HasOne("BicycleShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("Costumer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BicycleShop.Models.ProductOrder", b =>
                {
                    b.HasOne("BicycleShop.Models.Color", null)
                        .WithMany("products")
                        .HasForeignKey("Colors_ID");

                    b.HasOne("BicycleShop.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("Order_ID1");

                    b.HasOne("BicycleShop.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("Product_id1");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BicycleShop.Models.Color", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("BicycleShop.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BicycleShop.Models.Order", b =>
                {
                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("BicycleShop.Models.Product", b =>
                {
                    b.Navigation("ProductOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
