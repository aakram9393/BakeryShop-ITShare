﻿// <auto-generated />
using BakeryShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryShop.Data.Migrations
{
    [DbContext(typeof(BakeryShopContext))]
    [Migration("20210612174714_createDatabase")]
    partial class createDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("BakeryShop.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Describtion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Describtion = "Carrot Cake Any Description",
                            ImageName = "carrot_cake.jpg",
                            Name = "Carrot Cake",
                            Price = 0m
                        },
                        new
                        {
                            Id = 2,
                            Describtion = "Bread Any Description",
                            ImageName = "bread.jpg",
                            Name = "Bread",
                            Price = 0m
                        },
                        new
                        {
                            Id = 3,
                            Describtion = "Chocolate Cake Any Description",
                            ImageName = "chocolate_cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 0m
                        },
                        new
                        {
                            Id = 4,
                            Describtion = "Cup Cake Any Description",
                            ImageName = "cup_cake.jpg",
                            Name = "Cup Cake",
                            Price = 0m
                        },
                        new
                        {
                            Id = 5,
                            Describtion = "Lemon Tart Any Description",
                            ImageName = "lemon_tart.jpg",
                            Name = "Lemon Tart",
                            Price = 0m
                        },
                        new
                        {
                            Id = 6,
                            Describtion = "Pear Tart Any Description",
                            ImageName = "pear_tart.jpg",
                            Name = "Pear Tart",
                            Price = 0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}