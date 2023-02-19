﻿// <auto-generated />
using System;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230218045147_FPTBook")]
    partial class FPTBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessObjects.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ad_pass")
                        .HasColumnType("int");

                    b.Property<string>("ad_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("BusinessObjects.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("book_author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("book_price")
                        .HasColumnType("float");

                    b.Property<int>("cate_id")
                        .HasColumnType("int");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("cate_id");

                    b.HasIndex("owner_id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BusinessObjects.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("cart_quantity")
                        .HasColumnType("int");

                    b.Property<double>("cart_totalPrice")
                        .HasColumnType("float");

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("cus_id")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BusinessObjects.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("cate_des")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cate_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BusinessObjects.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("cus_address")
                        .HasColumnType("int");

                    b.Property<int>("cus_name")
                        .HasColumnType("int");

                    b.Property<int>("cus_pass")
                        .HasColumnType("int");

                    b.Property<int>("cus_username")
                        .HasColumnType("int");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.Property<string>("shippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<double>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BusinessObjects.OrderDetails", b =>
                {
                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("book_id")
                        .HasColumnType("int");

                    b.HasKey("order_id", "book_id");

                    b.HasIndex("book_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BusinessObjects.StoreOwner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("own_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("own_pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("own_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("store_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("StoreOwners");
                });

            modelBuilder.Entity("BusinessObjects.Book", b =>
                {
                    b.HasOne("BusinessObjects.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("cate_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.StoreOwner", "StoreOwner")
                        .WithMany("Books")
                        .HasForeignKey("owner_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("StoreOwner");
                });

            modelBuilder.Entity("BusinessObjects.Cart", b =>
                {
                    b.HasOne("BusinessObjects.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("BusinessObjects.Cart", "cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.HasOne("BusinessObjects.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("BusinessObjects.OrderDetails", b =>
                {
                    b.HasOne("BusinessObjects.Book", "Book")
                        .WithMany()
                        .HasForeignKey("book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BusinessObjects.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BusinessObjects.Customer", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BusinessObjects.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BusinessObjects.StoreOwner", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}