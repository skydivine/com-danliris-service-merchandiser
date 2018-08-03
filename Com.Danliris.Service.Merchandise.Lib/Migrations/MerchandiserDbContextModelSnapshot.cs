﻿// <auto-generated />
using Com.Danliris.Service.Merchandiser.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Danliris.Service.Merchandiser.Lib.Migrations
{
    [DbContext(typeof(MerchandiserDbContext))]
    partial class MerchandiserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.ArticleColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleColors");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AccessoriesAllowance");

                    b.Property<bool>("Active");

                    b.Property<string>("Article")
                        .HasMaxLength(500);

                    b.Property<int>("AutoIncrementNumber");

                    b.Property<string>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<double>("CommissionPortion");

                    b.Property<double>("CommissionRate");

                    b.Property<string>("Commodity")
                        .HasMaxLength(500);

                    b.Property<string>("CommodityDescription")
                        .HasMaxLength(3000);

                    b.Property<string>("ComodityID");

                    b.Property<DateTimeOffset>("ConfirmDate");

                    b.Property<double>("ConfirmPrice");

                    b.Property<string>("Convection")
                        .HasMaxLength(500);

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<int>("EfficiencyId");

                    b.Property<double>("EfficiencyValue");

                    b.Property<double>("FabricAllowance");

                    b.Property<double>("Freight");

                    b.Property<double>("FreightCost");

                    b.Property<string>("ImagePath");

                    b.Property<double>("Index");

                    b.Property<double>("Insurance");

                    b.Property<int>("LeadTime");

                    b.Property<double>("NETFOB");

                    b.Property<double>("NETFOBP");

                    b.Property<double>("OTL1CalculatedRate");

                    b.Property<int>("OTL1Id");

                    b.Property<double>("OTL1Rate");

                    b.Property<double>("OTL2CalculatedRate");

                    b.Property<int>("OTL2Id");

                    b.Property<double>("OTL2Rate");

                    b.Property<double>("ProductionCost");

                    b.Property<int>("Quantity");

                    b.Property<int?>("RO_GarmentId");

                    b.Property<string>("RO_Number")
                        .HasMaxLength(100);

                    b.Property<int>("RateId");

                    b.Property<double>("RateValue");

                    b.Property<double>("Risk");

                    b.Property<double>("SMV_Cutting");

                    b.Property<double>("SMV_Finishing");

                    b.Property<double>("SMV_Sewing");

                    b.Property<double>("SMV_Total");

                    b.Property<string>("Section")
                        .HasMaxLength(500);

                    b.Property<string>("SizeRange")
                        .HasMaxLength(500);

                    b.Property<int>("THRId");

                    b.Property<double>("THRRate");

                    b.Property<string>("UOMCode");

                    b.Property<string>("UOMID");

                    b.Property<string>("UOMUnit");

                    b.Property<int>("WageId");

                    b.Property<double>("WageRate");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("RO_GarmentId")
                        .IsUnique()
                        .HasFilter("[RO_GarmentId] IS NOT NULL");

                    b.ToTable("CostCalculationGarments");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment_Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AutoIncrementNumber");

                    b.Property<double>("BudgetQuantity");

                    b.Property<double?>("CM_Price");

                    b.Property<string>("CategoryId");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Composition");

                    b.Property<string>("Construction");

                    b.Property<string>("Convection");

                    b.Property<double>("Conversion");

                    b.Property<int>("CostCalculationGarmentId");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<string>("Information")
                        .HasMaxLength(500);

                    b.Property<string>("PO")
                        .HasMaxLength(100);

                    b.Property<string>("PO_SerialNumber");

                    b.Property<double>("Price");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductId");

                    b.Property<double>("Quantity");

                    b.Property<double>("ShippingFeePortion");

                    b.Property<double>("Total");

                    b.Property<double>("TotalShippingFee");

                    b.Property<string>("UOMPriceId");

                    b.Property<string>("UOMPriceName")
                        .HasMaxLength(500);

                    b.Property<string>("UOMQuantityId");

                    b.Property<string>("UOMQuantityName")
                        .HasMaxLength(500);

                    b.Property<string>("Width");

                    b.Property<string>("Yarn");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<bool>("isFabricCM");

                    b.HasKey("Id");

                    b.HasIndex("CostCalculationGarmentId");

                    b.ToTable("CostCalculationGarment_Materials");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.Efficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<int>("FinalRange");

                    b.Property<int>("InitialRange");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Value");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Efficiencies");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Value");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<int>("CostCalculationGarmentId");

                    b.Property<string>("ImagesName");

                    b.Property<string>("ImagesPath");

                    b.Property<string>("Instruction")
                        .HasMaxLength(3000);

                    b.Property<int>("Total");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("RO_Garments");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment_SizeBreakdown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<int>("ColorId")
                        .HasMaxLength(500);

                    b.Property<string>("ColorName")
                        .HasMaxLength(500);

                    b.Property<int>("RO_GarmentId");

                    b.Property<int>("Total");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("RO_GarmentId");

                    b.ToTable("RO_Garment_SizeBreakdowns");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment_SizeBreakdown_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Information")
                        .HasMaxLength(3000);

                    b.Property<int>("Quantity");

                    b.Property<int>("RO_Garment_SizeBreakdownId");

                    b.Property<string>("Size")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("RO_Garment_SizeBreakdownId");

                    b.ToTable("RO_Garment_SizeBreakdown_Details");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment", b =>
                {
                    b.HasOne("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment", "RO_Garment")
                        .WithOne("CostCalculationGarment")
                        .HasForeignKey("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment", "RO_GarmentId");
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment_Material", b =>
                {
                    b.HasOne("Com.Danliris.Service.Merchandiser.Lib.Models.CostCalculationGarment", "CostCalculationGarment")
                        .WithMany("CostCalculationGarment_Materials")
                        .HasForeignKey("CostCalculationGarmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment_SizeBreakdown", b =>
                {
                    b.HasOne("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment", "RO_Garment")
                        .WithMany("RO_Garment_SizeBreakdowns")
                        .HasForeignKey("RO_GarmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment_SizeBreakdown_Detail", b =>
                {
                    b.HasOne("Com.Danliris.Service.Merchandiser.Lib.Models.RO_Garment_SizeBreakdown", "RO_Garment_SizeBreakdown")
                        .WithMany("RO_Garment_SizeBreakdown_Details")
                        .HasForeignKey("RO_Garment_SizeBreakdownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
