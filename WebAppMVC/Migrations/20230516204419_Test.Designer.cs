﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMVC.Data;

#nullable disable

namespace WebAppMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230516204419_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAppMVC.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_KoalaCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("FK_KoalaCustomerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("WebAppMVC.Models.CartProduct", b =>
                {
                    b.Property<int>("CartProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartProductId"));

                    b.Property<int>("FK_CartId")
                        .HasColumnType("int");

                    b.Property<int>("Fk_ProductId")
                        .HasColumnType("int");

                    b.HasKey("CartProductId");

                    b.HasIndex("FK_CartId");

                    b.HasIndex("Fk_ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("WebAppMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Content")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("parentId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebAppMVC.Models.KoalaCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 11,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d5235a4c-76de-4116-b96d-832a5ae0e43d",
                            Email = "jon.westman@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Jon",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Westman",
                            LockoutEnabled = true,
                            NormalizedEmail = "JON.WESTMAN@MAIL.COM",
                            NormalizedUserName = "JON.WESTMAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9634),
                            SecurityStamp = "HL6ILB3DGTLX6CWG5FYGORM5HUJ4LZ4GYE6AF354NG54PC6OJFHA",
                            TwoFactorEnabled = false,
                            UserName = "jon.westman@mail.com"
                        },
                        new
                        {
                            Id = 12,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f593cac-f367-4c99-a4c0-593235d5882a",
                            Email = "bjorn.agnemo@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Björn",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Agnemo",
                            LockoutEnabled = true,
                            NormalizedEmail = "BJORN.AGNEMO@MAIL.COM",
                            NormalizedUserName = "BJORN.AGNEMO@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9693),
                            SecurityStamp = "FJNAYIRVEBW754UEHYOM4PWKOSRZPGCR74S4XOGP3IXVX5D3CVWQ",
                            TwoFactorEnabled = false,
                            UserName = "bjorn.agnemo@mail.com"
                        },
                        new
                        {
                            Id = 13,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa8bf9f4-7a9b-42b6-881c-8681f9808d77",
                            Email = "Oskar.Ahling@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Oskar",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Åhling",
                            LockoutEnabled = true,
                            NormalizedEmail = "OSKAR.AHLING@MAIL.COM",
                            NormalizedUserName = "OSKAR.AHLING@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9702),
                            SecurityStamp = "YH3AXUDGP2CGMA6LRCVCMP3BSPCK74FRTXCT4WRYTIF7D5NRVYUQ",
                            TwoFactorEnabled = false,
                            UserName = "Oskar.Ahling@mail.com"
                        },
                        new
                        {
                            Id = 14,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e1abd513-2a1c-42b5-b41b-d287c2d1984b",
                            Email = "Reidar.Nilsen@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Reidar",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Nilsen",
                            LockoutEnabled = true,
                            NormalizedEmail = "REIDAR.NILSEN@MAIL.COM",
                            NormalizedUserName = "REIDAR.NILSEN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9711),
                            SecurityStamp = "BEWA3FHZUINAOB64DO22VAFIO3OC24JFGRK7PNPRCZ3MK2UAH5RA",
                            TwoFactorEnabled = false,
                            UserName = "Reidar.Nilsen@mail.com"
                        },
                        new
                        {
                            Id = 15,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "01140f0d-5e9f-409f-adae-072b706ff55b",
                            Email = "Ina.Nilsson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Ina",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Nilsson",
                            LockoutEnabled = true,
                            NormalizedEmail = "INA.NILSSON@MAIL.COM",
                            NormalizedUserName = "INA.NILSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9720),
                            SecurityStamp = "5NDAKAVHTA5Z7TAQPTHAQ4MKRVRHKYFN7WVB3EJDCVHGU6LMV3NA",
                            TwoFactorEnabled = false,
                            UserName = "Ina.Nilsson@mail.com"
                        },
                        new
                        {
                            Id = 16,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4fbe0493-2aff-4d59-8fca-e0bdd03df84b",
                            Email = "Martin.Petersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Martin",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Petersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "MARTIN.PETERSSON@MAIL.COM",
                            NormalizedUserName = "MARTIN.PETERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9729),
                            SecurityStamp = "P2SDHRM3GSSWYMKJZW26TJDUB67NI65HRGKAFXNO7DR26MT4PG7A",
                            TwoFactorEnabled = false,
                            UserName = "Martin.Petersson@mail.com"
                        },
                        new
                        {
                            Id = 17,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21eab18b-4499-4b34-84bd-a75edc02e471",
                            Email = "Steve.Carell@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Steve",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Carell",
                            LockoutEnabled = true,
                            NormalizedEmail = "STEVE.CARELL@MAIL.COM",
                            NormalizedUserName = "STEVE.CARELL@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9749),
                            SecurityStamp = "IXT2IZC7XGM26EOG7QIVZLTSARIPCVYOJJIUI56MGOB5FQHM4JZQ",
                            TwoFactorEnabled = false,
                            UserName = "Steve.Carell@mail.com"
                        },
                        new
                        {
                            Id = 18,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "87b8ff09-9000-4eb1-ae15-5344e43852e5",
                            Email = "Grogu.Mandelorian@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Grogu",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Mandelorian",
                            LockoutEnabled = true,
                            NormalizedEmail = "GROGU.MANDELORIAN@MAIL.COM",
                            NormalizedUserName = "GROGU.MANDELORIAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9758),
                            SecurityStamp = "ZANUQC47CL53SQCBSNWTUNMXJUG33GAOGBWPSZG3EEJSPU22IDYA",
                            TwoFactorEnabled = false,
                            UserName = "Grogu.Mandelorian@mail.com"
                        },
                        new
                        {
                            Id = 19,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6f97042-9953-4f9f-a813-56fdde9dd6f6",
                            Email = "Lotta.Svensson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Lotta",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Svensson",
                            LockoutEnabled = true,
                            NormalizedEmail = "LOTTA.SVENSSON@MAIL.COM",
                            NormalizedUserName = "LOTTA.SVENSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9787),
                            SecurityStamp = "26BMRZ7BGRCN2FDEL5SCJN5DHSHBXC7ECBV5J6LLWK3J7MGBSL3A",
                            TwoFactorEnabled = false,
                            UserName = "Lotta.Svensson@mail.com"
                        },
                        new
                        {
                            Id = 20,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5531053b-032f-4828-af3a-760e0a3990b8",
                            Email = "Emilia.Ristersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Emilia",
                            LastLogin = new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            LastName = "Ristersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "EMILIA.RISTERSSON@MAIL.COM",
                            NormalizedUserName = "EMILIA.RISTERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9796),
                            SecurityStamp = "CLZRZLFQL6Z3LDYLFWCFWQ2NRSPQRVUDKZE2S2YUAX2R3NBNIA4A",
                            TwoFactorEnabled = false,
                            UserName = "Emilia.Ristersson@mail.com"
                        });
                });

            modelBuilder.Entity("WebAppMVC.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("Content")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_KoalaCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfItems")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Totalamount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("FK_KoalaCustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebAppMVC.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebAppMVC.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryId"));

                    b.Property<int>("FK_CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FK_ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductCategoryId");

                    b.HasIndex("FK_CategoryId");

                    b.HasIndex("FK_ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("WebAppMVC.Models.ProductReview", b =>
                {
                    b.Property<int>("ProductReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductReviewId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FK_ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductReviewId");

                    b.HasIndex("FK_ProductId");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppMVC.Models.Cart", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", "KoalaCustomers")
                        .WithMany()
                        .HasForeignKey("FK_KoalaCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoalaCustomers");
                });

            modelBuilder.Entity("WebAppMVC.Models.CartProduct", b =>
                {
                    b.HasOne("WebAppMVC.Models.Cart", "Carts")
                        .WithMany()
                        .HasForeignKey("FK_CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppMVC.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("Fk_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAppMVC.Models.Order", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", "KoalaCustomers")
                        .WithMany()
                        .HasForeignKey("FK_KoalaCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoalaCustomers");
                });

            modelBuilder.Entity("WebAppMVC.Models.ProductCategory", b =>
                {
                    b.HasOne("WebAppMVC.Models.Category", "Categorys")
                        .WithMany()
                        .HasForeignKey("FK_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppMVC.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("FK_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorys");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAppMVC.Models.ProductReview", b =>
                {
                    b.HasOne("WebAppMVC.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("FK_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}