﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackYourFood.DAL;

#nullable disable

namespace TrackYourFood.DAL.Migrations
{
    [DbContext(typeof(TrackYourFoodContext))]
    [Migration("20221225141626_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.AddedFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("CalculatedCarbo")
                        .HasColumnType("float");

                    b.Property<double>("CalculatedFat")
                        .HasColumnType("float");

                    b.Property<double>("CalculatedKcal")
                        .HasColumnType("float");

                    b.Property<double>("CalculatedProtein")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7006));

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(7587));

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodID");

                    b.HasIndex("UserID");

                    b.ToTable("AddedFoods");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8553));

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(8868));

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Vegetables",
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Fruits",
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Dairy",
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Grains",
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Protein",
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Editor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7618));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(7935));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Editors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "System1",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Editor1",
                            LastName = "Editor1",
                            ModifiedBy = "System1",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Password = "123qwe.",
                            UserName = "editor1@tyf.com"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "System1",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Editor2",
                            LastName = "Editor2",
                            ModifiedBy = "System1",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Password = "123qwe.",
                            UserName = "editor2@tyf.com"
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "System1",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Editor3",
                            LastName = "Editor3",
                            ModifiedBy = "System1",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Password = "123qwe.",
                            UserName = "editor3@tyf.com"
                        });
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("CarboValue")
                        .HasColumnType("float");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 284, DateTimeKind.Local).AddTicks(9848));

                    b.Property<double>("FatValue")
                        .HasColumnType("float");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kcal")
                        .HasColumnType("float");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(279));

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProteinValue")
                        .HasColumnType("float");

                    b.Property<int>("UnitID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("MealID");

                    b.HasIndex("UnitID");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CarboValue = 11.07,
                            CategoryID = 1,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 10.380000000000001,
                            FoodName = "Green Peas",
                            Kcal = 147.0,
                            MealID = 2,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\bezelye.jpg",
                            ProteinValue = 3.48,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 2,
                            CarboValue = 4.7000000000000002,
                            CategoryID = 1,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 5.0,
                            FoodName = "Artichokes in oil",
                            Kcal = 79.0,
                            MealID = 2,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\zeytinyagli-enginar-500x500.jpeg",
                            ProteinValue = 1.8,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 3,
                            CarboValue = 19.300000000000001,
                            CategoryID = 2,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 0.23999999999999999,
                            FoodName = "Apple",
                            Kcal = 73.0,
                            MealID = 4,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\star-elma-p-2246.jpg",
                            ProteinValue = 0.35999999999999999,
                            UnitID = 2
                        },
                        new
                        {
                            ID = 4,
                            CarboValue = 26.949999999999999,
                            CategoryID = 2,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 0.39000000000000001,
                            FoodName = "Banana",
                            Kcal = 105.0,
                            MealID = 4,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\benekli-muz.jpg",
                            ProteinValue = 1.29,
                            UnitID = 2
                        },
                        new
                        {
                            ID = 5,
                            CarboValue = 4.6600000000000001,
                            CategoryID = 3,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 3.3500000000000001,
                            FoodName = "Milk",
                            Kcal = 62.0,
                            MealID = 1,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\sut.jpg",
                            ProteinValue = 3.3199999999999998,
                            UnitID = 4
                        },
                        new
                        {
                            ID = 6,
                            CarboValue = 4.0899999999999999,
                            CategoryID = 3,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 21.280000000000001,
                            FoodName = "White cheese",
                            Kcal = 264.0,
                            MealID = 1,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\beyazPeynir.jpg",
                            ProteinValue = 14.210000000000001,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 7,
                            CarboValue = 29.399999999999999,
                            CategoryID = 4,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 1.3999999999999999,
                            FoodName = "Dried beans",
                            Kcal = 282.0,
                            MealID = 2,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\kurufasulye.jpg",
                            ProteinValue = 22.0,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 8,
                            CarboValue = 17.199999999999999,
                            CategoryID = 4,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 0.82999999999999996,
                            FoodName = "Pea meal",
                            Kcal = 110.0,
                            MealID = 2,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\nohut.jpg",
                            ProteinValue = 8.3000000000000007,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 9,
                            CarboValue = 0.0,
                            CategoryID = 5,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 6.6299999999999999,
                            FoodName = "Beef steak",
                            Kcal = 187.0,
                            MealID = 3,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\biftek.jpg",
                            ProteinValue = 29.809999999999999,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 12,
                            CarboValue = 0.0,
                            CategoryID = 5,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 1.24,
                            FoodName = "Chicken breast",
                            Kcal = 110.0,
                            MealID = 3,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\izgara-tavuk-gogsu.jpg",
                            ProteinValue = 23.100000000000001,
                            UnitID = 1
                        },
                        new
                        {
                            ID = 11,
                            CarboValue = 0.0,
                            CategoryID = 5,
                            CreatedBy = "Pelin Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FatValue = 5.2999999999999998,
                            FoodName = "Boiled Egg",
                            Kcal = 78.0,
                            MealID = 1,
                            ModifiedBy = "Pelin Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Picture = "C:\\Users\\emreg\\OneDrive\\Masaüstü\\TrackYourFood\\FoodPicture\\yumurta.jpg",
                            ProteinValue = 6.29,
                            UnitID = 1
                        });
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1230));

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(1710));

                    b.HasKey("ID");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            MealType = "Breakfast",
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            MealType = "Lunch",
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            MealType = "Dinner",
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            MealType = "Snack",
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Unit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(3377));

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(4011));

                    b.Property<string>("NameOfUnit")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            NameOfUnit = "gr"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            NameOfUnit = "quantity"
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            NameOfUnit = "portion"
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "Emre Gurcan",
                            CreatedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedBy = "Emre Gurcan",
                            ModifiedDate = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            NameOfUnit = "litre"
                        });
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6523));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 12, 25, 17, 16, 26, 285, DateTimeKind.Local).AddTicks(6864));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.AddedFood", b =>
                {
                    b.HasOne("TrackYourFood.Entites.Concrete.Food", "Food")
                        .WithMany("AddedFoods")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourFood.Entites.Concrete.User", "User")
                        .WithMany("AddedFoods")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Food", b =>
                {
                    b.HasOne("TrackYourFood.Entites.Concrete.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourFood.Entites.Concrete.Meal", "Meal")
                        .WithMany("Foods")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourFood.Entites.Concrete.Unit", "Unit")
                        .WithMany("Foods")
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Meal");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Food", b =>
                {
                    b.Navigation("AddedFoods");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Meal", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.Unit", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("TrackYourFood.Entites.Concrete.User", b =>
                {
                    b.Navigation("AddedFoods");
                });
#pragma warning restore 612, 618
        }
    }
}
