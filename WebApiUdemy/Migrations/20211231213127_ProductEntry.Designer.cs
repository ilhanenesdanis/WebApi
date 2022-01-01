﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiUdemy.Data;

namespace WebApiUdemy.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20211231213127_ProductEntry")]
    partial class ProductEntry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiUdemy.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Perice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 12, 29, 0, 31, 26, 944, DateTimeKind.Local).AddTicks(6148),
                            Name = "Bilgisayar",
                            Perice = 15500m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 12, 2, 0, 31, 26, 945, DateTimeKind.Local).AddTicks(4304),
                            Name = "Monitör",
                            Perice = 2899m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 11, 2, 0, 31, 26, 945, DateTimeKind.Local).AddTicks(4330),
                            Name = "Klavye",
                            Perice = 158m,
                            Stock = 52
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
