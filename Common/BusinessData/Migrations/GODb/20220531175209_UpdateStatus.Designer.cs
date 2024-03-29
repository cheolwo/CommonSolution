﻿// <auto-generated />
using System;
using BusinessData.ofGroupOrder.ofDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessData.Migrations.GODb
{
    [DbContext(typeof(GODbContext))]
    [Migration("20220531175209_UpdateStatus")]
    partial class UpdateStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FailLogin")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Center");
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Barcode")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HsCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OpponentBusinessUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Commodity");
                });

            modelBuilder.Entity("BusinessData.EStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MStatusId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("MStatusId");

                    b.ToTable("EStatus");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SStatusId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.HasIndex("SStatusId");

                    b.ToTable("MStatus");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Container")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.ToTable("SStatus");
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.EGOC", b =>
                {
                    b.HasBaseType("BusinessData.EStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("EGOC", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.GOC", b =>
                {
                    b.HasBaseType("BusinessData.Center");

                    b.Property<string>("CenterCards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderCenters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("GOCC", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.GOCC", b =>
                {
                    b.HasBaseType("BusinessData.Commodity");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("GOCCC", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.MGOC", b =>
                {
                    b.HasBaseType("BusinessData.MStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("MGOC", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.SGOC", b =>
                {
                    b.HasBaseType("BusinessData.SStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("SGOC", (string)null);
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("Commodities")
                        .HasForeignKey("CenterId");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("BusinessData.EStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("EStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("EStatuses")
                        .HasForeignKey("CommodityId");

                    b.HasOne("BusinessData.MStatus", "MStatus")
                        .WithMany("EStatuses")
                        .HasForeignKey("MStatusId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");

                    b.Navigation("MStatus");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("MStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("MStatuses")
                        .HasForeignKey("CommodityId");

                    b.HasOne("BusinessData.SStatus", "SStatus")
                        .WithMany("MStatuses")
                        .HasForeignKey("SStatusId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");

                    b.Navigation("SStatus");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.HasOne("BusinessData.Center", "Center")
                        .WithMany("SStatuses")
                        .HasForeignKey("CenterId");

                    b.HasOne("BusinessData.Commodity", "Commodity")
                        .WithMany("SStatuses")
                        .HasForeignKey("CommodityId");

                    b.Navigation("Center");

                    b.Navigation("Commodity");
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.EGOC", b =>
                {
                    b.HasOne("BusinessData.EStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofGroupOrder.ofModel.EGOC", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.GOC", b =>
                {
                    b.HasOne("BusinessData.Center", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofGroupOrder.ofModel.GOC", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.GOCC", b =>
                {
                    b.HasOne("BusinessData.Commodity", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofGroupOrder.ofModel.GOCC", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.MGOC", b =>
                {
                    b.HasOne("BusinessData.MStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofGroupOrder.ofModel.MGOC", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofGroupOrder.ofModel.SGOC", b =>
                {
                    b.HasOne("BusinessData.SStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofGroupOrder.ofModel.SGOC", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.Center", b =>
                {
                    b.Navigation("Commodities");

                    b.Navigation("EStatuses");

                    b.Navigation("MStatuses");

                    b.Navigation("SStatuses");
                });

            modelBuilder.Entity("BusinessData.Commodity", b =>
                {
                    b.Navigation("EStatuses");

                    b.Navigation("MStatuses");

                    b.Navigation("SStatuses");
                });

            modelBuilder.Entity("BusinessData.MStatus", b =>
                {
                    b.Navigation("EStatuses");
                });

            modelBuilder.Entity("BusinessData.SStatus", b =>
                {
                    b.Navigation("MStatuses");
                });
#pragma warning restore 612, 618
        }
    }
}
