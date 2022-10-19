﻿// <auto-generated />
using System;
using DAl.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAl.Model.Order", b =>
                {
                    b.Property<int>("Order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_id"), 1L, 1);

                    b.Property<string>("Order_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.HasKey("Order_id");

                    b.HasIndex("Product_Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Order_id = 1,
                            Order_Status = "Active",
                            Order_date = new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Product_Id = 1
                        });
                });

            modelBuilder.Entity("DAl.Model.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Id"), 1L, 1);

                    b.Property<double>("Product_Price")
                        .HasColumnType("float");

                    b.Property<string>("Product_stock_qun")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_Id = 1,
                            Product_Price = 100.09999999999999,
                            Product_stock_qun = "10"
                        });
                });

            modelBuilder.Entity("DAl.Model.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"), 1L, 1);

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.HasIndex("Order_Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_Id = 1,
                            Order_Id = 1,
                            User_Name = "ABC"
                        });
                });

            modelBuilder.Entity("DAl.Model.Order", b =>
                {
                    b.HasOne("DAl.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAl.Model.User", b =>
                {
                    b.HasOne("DAl.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
