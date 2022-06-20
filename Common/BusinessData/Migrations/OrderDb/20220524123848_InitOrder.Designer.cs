﻿// <auto-generated />
using System;
using BusinessData.ofOrder.ofDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessData.Migrations.OrderDb
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20220524123848_InitOrder")]
    partial class InitOrder
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

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("CommodityId");

                    b.ToTable("SStatus");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.EOCommodity", b =>
                {
                    b.HasBaseType("BusinessData.EStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OrderCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OutgoingQuantity")
                        .HasColumnType("int");

                    b.HasIndex("MOCommodityId");

                    b.HasIndex("OCommodityId");

                    b.HasIndex("OrderCenterId");

                    b.ToTable("EOCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.MOCommodity", b =>
                {
                    b.HasBaseType("BusinessData.MStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OrderCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SOCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("OCommodityId");

                    b.HasIndex("OrderCenterId");

                    b.HasIndex("SOCommodityId");

                    b.ToTable("MOCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OCommodity", b =>
                {
                    b.HasBaseType("BusinessData.Commodity");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("OrderCenterId");

                    b.ToTable("OCommodity", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OrderCenter", b =>
                {
                    b.HasBaseType("BusinessData.Center");

                    b.Property<string>("CenterCards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterIPAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CenterMacAddresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OrderCenter", (string)null);
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.SOCommodity", b =>
                {
                    b.HasBaseType("BusinessData.SStatus");

                    b.Property<string>("ChangedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Docs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageofInfos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incorterms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OCommodityId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OrderCenterId")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualityTerms")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("OCommodityId");

                    b.HasIndex("OrderCenterId");

                    b.ToTable("SOCommodity", (string)null);
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

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.EOCommodity", b =>
                {
                    b.HasOne("BusinessData.EStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofOrder.ofModel.EOCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofOrder.ofModel.MOCommodity", "MOCommodity")
                        .WithMany("EOCommodities")
                        .HasForeignKey("MOCommodityId");

                    b.HasOne("BusinessData.ofOrder.ofModel.OCommodity", "OCommodity")
                        .WithMany("EOCommodities")
                        .HasForeignKey("OCommodityId");

                    b.HasOne("BusinessData.ofOrder.ofModel.OrderCenter", "OrderCenter")
                        .WithMany("EOCommodities")
                        .HasForeignKey("OrderCenterId");

                    b.Navigation("MOCommodity");

                    b.Navigation("OCommodity");

                    b.Navigation("OrderCenter");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.MOCommodity", b =>
                {
                    b.HasOne("BusinessData.MStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofOrder.ofModel.MOCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofOrder.ofModel.OCommodity", "OCommodity")
                        .WithMany("MOCommodities")
                        .HasForeignKey("OCommodityId");

                    b.HasOne("BusinessData.ofOrder.ofModel.OrderCenter", "OrderCenter")
                        .WithMany("MOCommodities")
                        .HasForeignKey("OrderCenterId");

                    b.HasOne("BusinessData.ofOrder.ofModel.SOCommodity", "SOCommodity")
                        .WithMany("MOCommodities")
                        .HasForeignKey("SOCommodityId");

                    b.Navigation("OCommodity");

                    b.Navigation("OrderCenter");

                    b.Navigation("SOCommodity");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OCommodity", b =>
                {
                    b.HasOne("BusinessData.Commodity", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofOrder.ofModel.OCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofOrder.ofModel.OrderCenter", "OrderCenter")
                        .WithMany("OCommodities")
                        .HasForeignKey("OrderCenterId");

                    b.Navigation("OrderCenter");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OrderCenter", b =>
                {
                    b.HasOne("BusinessData.Center", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofOrder.ofModel.OrderCenter", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.SOCommodity", b =>
                {
                    b.HasOne("BusinessData.SStatus", null)
                        .WithOne()
                        .HasForeignKey("BusinessData.ofOrder.ofModel.SOCommodity", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("BusinessData.ofOrder.ofModel.OCommodity", "OCommodity")
                        .WithMany("SOCommodities")
                        .HasForeignKey("OCommodityId");

                    b.HasOne("BusinessData.ofOrder.ofModel.OrderCenter", "OrderCenter")
                        .WithMany("SOCommodities")
                        .HasForeignKey("OrderCenterId");

                    b.Navigation("OCommodity");

                    b.Navigation("OrderCenter");
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

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.MOCommodity", b =>
                {
                    b.Navigation("EOCommodities");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OCommodity", b =>
                {
                    b.Navigation("EOCommodities");

                    b.Navigation("MOCommodities");

                    b.Navigation("SOCommodities");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.OrderCenter", b =>
                {
                    b.Navigation("EOCommodities");

                    b.Navigation("MOCommodities");

                    b.Navigation("OCommodities");

                    b.Navigation("SOCommodities");
                });

            modelBuilder.Entity("BusinessData.ofOrder.ofModel.SOCommodity", b =>
                {
                    b.Navigation("MOCommodities");
                });
#pragma warning restore 612, 618
        }
    }
}