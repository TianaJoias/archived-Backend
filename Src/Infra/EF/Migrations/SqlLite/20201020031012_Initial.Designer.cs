﻿// <auto-generated />
using System;
using Infra.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.EF.Migrations.SqlLite
{
    [DbContext(typeof(TianaJoiasContextDB))]
    [Migration("20201020031012_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Domain.Account.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<string>("Roles")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Domain.Account.IdentityProvider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Provider")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("IdentityProviders");
                });

            modelBuilder.Entity("Domain.Catalog.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<Guid>("ChannelId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Closed")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Opened")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Domain.Catalog.CatalogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<Guid?>("CatalogId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EAN")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LongDescription")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LotId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("CatalogItems");
                });

            modelBuilder.Entity("Domain.Catalog.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<Guid?>("CurrentCatalogId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCatalogId");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("Domain.Portifolio.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EAN")
                        .HasColumnType("TEXT");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Domain.Portifolio.ProductCategory", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TagId")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Domain.Portifolio.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Domain.Stock.Lot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("EAN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("Domain.Stock.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("LotSupplier", b =>
                {
                    b.Property<Guid>("LotsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SuppliersId")
                        .HasColumnType("TEXT");

                    b.HasKey("LotsId", "SuppliersId");

                    b.HasIndex("SuppliersId");

                    b.ToTable("LotSupplier");
                });

            modelBuilder.Entity("Domain.Account.Account", b =>
                {
                    b.OwnsOne("Domain.Account.User", "User", b1 =>
                        {
                            b1.Property<Guid>("AccountId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Email")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Password")
                                .HasColumnType("TEXT");

                            b1.HasKey("AccountId");

                            b1.ToTable("Accounts");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Account.IdentityProvider", b =>
                {
                    b.HasOne("Domain.Account.Account", null)
                        .WithMany("ExternalProviders")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Domain.Catalog.Catalog", b =>
                {
                    b.HasOne("Domain.Catalog.Channel", "Channel")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");
                });

            modelBuilder.Entity("Domain.Catalog.CatalogItem", b =>
                {
                    b.HasOne("Domain.Catalog.Catalog", null)
                        .WithMany("Items")
                        .HasForeignKey("CatalogId")
                        .HasConstraintName("FK_CATALOG_ITEM");
                });

            modelBuilder.Entity("Domain.Catalog.Channel", b =>
                {
                    b.HasOne("Domain.Catalog.Catalog", "CurrentCatalog")
                        .WithMany()
                        .HasForeignKey("CurrentCatalogId");

                    b.Navigation("CurrentCatalog");
                });

            modelBuilder.Entity("Domain.Portifolio.ProductCategory", b =>
                {
                    b.HasOne("Domain.Portifolio.Product", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Portifolio.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("LotSupplier", b =>
                {
                    b.HasOne("Domain.Stock.Lot", null)
                        .WithMany()
                        .HasForeignKey("LotsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Stock.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Account.Account", b =>
                {
                    b.Navigation("ExternalProviders");
                });

            modelBuilder.Entity("Domain.Catalog.Catalog", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Domain.Portifolio.Product", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}