﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PD324_01.Data;

#nullable disable

namespace PD324_01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240831114509_Add identity")]
    partial class Addidentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PD324_01.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Processors"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Videocards"
                        });
                });

            modelBuilder.Entity("PD324_01.Models.Identity.Role", b =>
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

            modelBuilder.Entity("PD324_01.Models.Identity.RoleClaim", b =>
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

            modelBuilder.Entity("PD324_01.Models.Identity.User", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserClaim", b =>
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

            modelBuilder.Entity("PD324_01.Models.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PD324_01.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "",
                            Image = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcRC98q4Vog6E0ThvsYJZ9M4zQYc7dC-BPrOut3rXMOpAHCgdRd4wlG7b7Y2Ml30vh9ijbrRhVrhizkWlyfQRB2AzspjWn3WTg4muTZFkWA&usqp=CAE",
                            Name = "AMD Ryzen 5 5500U",
                            Price = 3700.0m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "",
                            Image = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcTR0a-LCLAsE8kD7EyVZtQ4fWuOJFUr7om5GatUqr_LNAkbon0RnDxfWLE-uxZhFHuL_EWYtSRj3M5MTWlQsVymGKfBaDkbjBySMoIwj6qDdHa7xTmQOVD1&usqp=CAE",
                            Name = "intel core i9 14900k",
                            Price = 26406.0m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "",
                            Image = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcTTuRvD4ecfGFUT5OPX7Y0DUMVCa91IHyzbeqwO3TY6UNwhpfJoB6Harwwm83LcDEfP1bYo34LvJH-PkaKODY8Xwh-x1c1R6pqW_oRaeWDdkMjMTSWIzN8-gg&usqp=CAE",
                            Name = "AMD Ryzen Threadripper PRO 7995WX",
                            Price = 512876.0m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "",
                            Image = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcT_OzFW3PueJdquyAqLvXML8ex14absxwEKb9_ai1zWa3_bzk-GccmBsWblN47cJQXndg_ni1lcz8v1y0xTs3BGiu8NSgRXCYRElUKdTvyKjySYjbPQIQz8&usqp=CAE",
                            Name = "Nvidia RTX 4090",
                            Price = 88999.0m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "",
                            Image = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSN-HOzsGtF5sr9xFHO2ttuITyboTba__ey5QJXz5_vfQT2t_qdV9-qRnqgHlK4tvbY7DoprOEmbrqAW5VnDOZcdK2WkStUAMW-duANTnk&usqp=CAE",
                            Name = "AMD RX 6600",
                            Price = 7999.0m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "",
                            Image = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSbElEyWjjPP1cYTHLoyhnkZ3EJDbFsXQD1pNvJe6bSr1F5uCmMFThovMt2hRaP8BASxdTA5P2M6WIGNKnNnIwHb6OKPIy0LoyD6GurgAXU4iEen_Foj5W4&usqp=CAE",
                            Name = "Nvidia GeForce GTX 1080",
                            Price = 6500.0m
                        });
                });

            modelBuilder.Entity("PD324_01.Models.Identity.RoleClaim", b =>
                {
                    b.HasOne("PD324_01.Models.Identity.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserClaim", b =>
                {
                    b.HasOne("PD324_01.Models.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserLogin", b =>
                {
                    b.HasOne("PD324_01.Models.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserRole", b =>
                {
                    b.HasOne("PD324_01.Models.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PD324_01.Models.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.UserToken", b =>
                {
                    b.HasOne("PD324_01.Models.Identity.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PD324_01.Models.Product", b =>
                {
                    b.HasOne("PD324_01.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PD324_01.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.Role", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("PD324_01.Models.Identity.User", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Tokens");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
