﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Models;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20241122204225_ProductSeedData")]
    partial class ProductSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("StoreApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 1000m,
                            ProductName = "Product 1"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 2000m,
                            ProductName = "Product 2"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 3000m,
                            ProductName = "Product 3"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 4000m,
                            ProductName = "Product 4"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 5000m,
                            ProductName = "Product 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
