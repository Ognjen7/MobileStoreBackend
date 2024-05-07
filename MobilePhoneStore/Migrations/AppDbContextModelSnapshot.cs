﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MobilePhoneStore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MobilePhoneStore.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "China",
                            Name = "Huawei"
                        },
                        new
                        {
                            Id = 2,
                            Country = "China",
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 3,
                            Country = "China",
                            Name = "Honor"
                        },
                        new
                        {
                            Id = 4,
                            Country = "SAD",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 5,
                            Country = "Japan",
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("MobilePhoneStore.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableQuantity = 17,
                            ManufacturerId = 4,
                            Model = "iPhone 13",
                            OperatingSystem = "IOS",
                            Photo = "https://www.tehnomedia.rs/image/85400.jpg?tip=webp&tip_slike=0",
                            Price = 530.0
                        },
                        new
                        {
                            Id = 2,
                            AvailableQuantity = 12,
                            ManufacturerId = 4,
                            Model = "iPhone 14",
                            OperatingSystem = "IOS",
                            Photo = "https://www.tehnomedia.rs/image/91914.jpg?tip=webp&tip_slike=0",
                            Price = 625.0
                        },
                        new
                        {
                            Id = 3,
                            AvailableQuantity = 10,
                            ManufacturerId = 4,
                            Model = "iPhone 15 Pro",
                            OperatingSystem = "IOS",
                            Photo = "https://www.tehnomedia.rs/image/100132.jpg?tip=webp&tip_slike=0",
                            Price = 1180.0
                        },
                        new
                        {
                            Id = 4,
                            AvailableQuantity = 4,
                            ManufacturerId = 4,
                            Model = "iPhone 15",
                            OperatingSystem = "IOS",
                            Photo = "https://www.tehnomedia.rs/image/100086.jpg?tip=webp&tip_slike=0",
                            Price = 740.0
                        },
                        new
                        {
                            Id = 5,
                            AvailableQuantity = 7,
                            ManufacturerId = 5,
                            Model = "Galaxy Z Fold",
                            OperatingSystem = "Android",
                            Photo = "https://img.ep-cdn.com/i/500/500/al/alhkinftrpeswyxbgvou/samsung-galaxy-z-fold-4-12gb-256gb-black-cene.jpg",
                            Price = 1250.0
                        },
                        new
                        {
                            Id = 6,
                            AvailableQuantity = 5,
                            ManufacturerId = 5,
                            Model = "Galaxy S24 Ultra",
                            OperatingSystem = "Android",
                            Photo = "https://www.tehnomedia.rs/image/102822.jpg?tip=webp&tip_slike=0",
                            Price = 1260.0
                        },
                        new
                        {
                            Id = 7,
                            AvailableQuantity = 0,
                            ManufacturerId = 5,
                            Model = "Galaxy S23 Ultra",
                            OperatingSystem = "Android",
                            Photo = "https://www.tehnomedia.rs/image/95008.jpg?tip=webp&tip_slike=0",
                            Price = 1552.0
                        },
                        new
                        {
                            Id = 8,
                            AvailableQuantity = 2,
                            ManufacturerId = 5,
                            Model = "Galaxy A55",
                            OperatingSystem = "Android",
                            Photo = "https://www.tehnomedia.rs/image/104507.jpg?tip=webp&tip_slike=0",
                            Price = 466.0
                        },
                        new
                        {
                            Id = 9,
                            AvailableQuantity = 7,
                            ManufacturerId = 1,
                            Model = "P60 Pro",
                            OperatingSystem = "Android",
                            Photo = "https://img.gigatron.rs/img/products/large/image6467404c20680.jpg",
                            Price = 951.0
                        },
                        new
                        {
                            Id = 10,
                            AvailableQuantity = 5,
                            ManufacturerId = 1,
                            Model = "nova 11",
                            OperatingSystem = "Android",
                            Photo = "https://img.gigatron.rs/img/products/large/image652e84afa707f.jpg",
                            Price = 430.0
                        },
                        new
                        {
                            Id = 11,
                            AvailableQuantity = 0,
                            ManufacturerId = 1,
                            Model = "nova 10 SE",
                            OperatingSystem = "Android",
                            Photo = "https://img.gigatron.rs/img/products/large/image63c52aab38686.jpg",
                            Price = 291.0
                        },
                        new
                        {
                            Id = 12,
                            AvailableQuantity = 12,
                            ManufacturerId = 2,
                            Model = "14 Ultra",
                            OperatingSystem = "Android",
                            Photo = "https://www.giztop.com/media/catalog/product/cache/dc206057cdd42d7e34b9d36e347785ca/x/i/xiaomi_14_ultra_white.jpg",
                            Price = 1200.0
                        },
                        new
                        {
                            Id = 13,
                            AvailableQuantity = 15,
                            ManufacturerId = 2,
                            Model = "14",
                            OperatingSystem = "Android",
                            Photo = "https://www.tehnomedia.rs/image/103970.jpg?tip=webp&tip_slike=0",
                            Price = 855.0
                        },
                        new
                        {
                            Id = 14,
                            AvailableQuantity = 9,
                            ManufacturerId = 2,
                            Model = "13T Pro",
                            OperatingSystem = "Android",
                            Photo = "https://mi-srbija.rs/storage/product/images/4c/55/xiaomi-13t-pro-6539.png",
                            Price = 748.0
                        },
                        new
                        {
                            Id = 15,
                            AvailableQuantity = 12,
                            ManufacturerId = 3,
                            Model = "Magic6 Pro",
                            OperatingSystem = "Android",
                            Photo = "https://www.honor.com/content/dam/honor/my/product-list/smartphone/honor-magic6-pro/honor-magic6-pro-green.png",
                            Price = 1090.0
                        },
                        new
                        {
                            Id = 16,
                            AvailableQuantity = 4,
                            ManufacturerId = 3,
                            Model = "90 5G",
                            OperatingSystem = "Android",
                            Photo = "https://img.gigatron.rs/img/products/large/image64a7ec239245d.jpg",
                            Price = 440.0
                        },
                        new
                        {
                            Id = 17,
                            AvailableQuantity = 2,
                            ManufacturerId = 3,
                            Model = "Magic5 Lite",
                            OperatingSystem = "Android",
                            Photo = "https://api.tehnoteka.rs/uploads/cache/product_4x3/uploads/2024/01/honor-magic5-lite-8-256gb-emerald-green-659e89d880e04.jpeg",
                            Price = 195.0
                        },
                        new
                        {
                            Id = 18,
                            AvailableQuantity = 5,
                            ManufacturerId = 3,
                            Model = "X8a",
                            OperatingSystem = "Android",
                            Photo = "https://e-mobilni.rs/wp-content/uploads/2023/11/mobilni-telefon-honor-x8a-67-6gb-128gb-plavi-190763-291451.png",
                            Price = 141.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MobilePhoneStore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MobilePhoneStore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobilePhoneStore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MobilePhoneStore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobilePhoneStore.Models.Phone", b =>
                {
                    b.HasOne("MobilePhoneStore.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });
#pragma warning restore 612, 618
        }
    }
}
