﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestRazor.Model;

namespace TestRazor.Migrations
{
    [DbContext(typeof(Item.AppData))]
    partial class AppDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestRazor.Model.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BeginPrice")
                        .HasColumnType("decimal(7,2)");

                    b.Property<bool>("BetWasDone")
                        .HasColumnType("bit");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DurationTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ItemWasRedempt")
                        .HasColumnType("bit");

                    b.Property<long>("LastBetUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RedemtionPrice")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserCreatedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TestRazor.Model.Item+ConfirmToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LifeTimeMin")
                        .HasColumnType("int");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConfirmTokens");
                });

            modelBuilder.Entity("TestRazor.Model.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("PayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<string>("SellerTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TestRazor.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailWasConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemsList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrdersBetId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
