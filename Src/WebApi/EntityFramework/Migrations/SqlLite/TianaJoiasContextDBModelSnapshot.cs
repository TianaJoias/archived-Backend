﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Infra;

namespace WebApi.EntityFramework.Migrations.SqlLite
{
    [DbContext(typeof(TianaJoiasContextDB))]
    partial class TianaJoiasContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("WebApi.Controllers.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categories")
                        .HasColumnType("TEXT");

                    b.Property<string>("Colors")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Supplier")
                        .HasColumnType("TEXT");

                    b.Property<string>("Thematics")
                        .HasColumnType("TEXT");

                    b.Property<string>("Typologies")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}