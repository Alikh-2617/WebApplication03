﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication03.Data;

#nullable disable

namespace WebApplication03.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221206093016_Seeded Roll och Person")]
    partial class SeededRollochPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<string>("LanguagesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PeopleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LanguagesId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            LanguagesId = "d5196612-f8aa-40d2-b63f-848f2784c545",
                            PeopleId = "8acac708-9de3-4c4f-9d4e-84078cb75cc7"
                        });
                });

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87",
                            ConcurrencyStamp = "5789c979-0e02-4a06-9f34-e0b623339cbc",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ccbe6d77-4278-4923-ab05-d39d1253cc43",
                            ConcurrencyStamp = "ef6be23b-1abd-40c6-8de6-80dc45dd22f7",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "523eaa95-fa56-48f8-832e-0857fa68d910",
                            RoleId = "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("WebApplication03.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EfterName")
                        .IsRequired()
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<DateTime>("Register")
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
                            Id = "523eaa95-fa56-48f8-832e-0857fa68d910",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "0047c43c-5663-4fd1-8c9f-414201979585",
                            EfterName = "Adminson",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN1@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL8sWjQvZWGdRcMgkmWsrOOeHUMMMag4bL0EtPWsc0gaZYXrQhzCwhQw/HxOdjveKw==",
                            PhoneNumberConfirmed = false,
                            Register = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "dc982748-e92c-4298-ae94-232198abe103",
                            TwoFactorEnabled = false,
                            UserName = "admin1@admin.com"
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = "1a80182f-3ada-4153-9506-d0aebe277304",
                            Name = "GBG",
                            PostNumber = "415 52",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9612)
                        },
                        new
                        {
                            Id = "8ae4970a-9ba0-45d6-b86a-f0614f4f1175",
                            Name = "Järpen",
                            PostNumber = "415 55",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9619)
                        },
                        new
                        {
                            Id = "5d637e48-459a-4473-a2f7-4abeb9479918",
                            Name = "Mörsil",
                            PostNumber = "415 44",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9624)
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = "d802dc3f-3a04-487a-bd88-f741bf9e9316",
                            Name = "Sweden",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9653)
                        },
                        new
                        {
                            Id = "3be19c96-d6a9-4d59-b2f6-a0daa1dfa8c5",
                            Name = "Norway",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9662)
                        },
                        new
                        {
                            Id = "38d510ec-87a0-4e55-8a41-f92460b7ed3f",
                            Name = "Danmarc",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9666)
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = "d5196612-f8aa-40d2-b63f-848f2784c545",
                            Name = "Svenska",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(8471)
                        },
                        new
                        {
                            Id = "d9ac44e0-41ef-43cd-a65d-9f690c15bd3a",
                            Name = "Svenska",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9500)
                        },
                        new
                        {
                            Id = "9b02ecc2-50d4-42d3-a791-956267c20280",
                            Name = "Persiska",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9513)
                        },
                        new
                        {
                            Id = "17a57c38-3c3d-4f2e-a867-989a3846c50f",
                            Name = "Engleska",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9535)
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = "8acac708-9de3-4c4f-9d4e-84078cb75cc7",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(8562)
                        },
                        new
                        {
                            Id = "dfda4694-efaa-4698-9cdd-8847156ea371",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9563)
                        },
                        new
                        {
                            Id = "ab1d5607-9045-448f-808a-84e0ca1465f1",
                            Age = 32,
                            Name = "Ali 1",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9575)
                        },
                        new
                        {
                            Id = "fa0e8a8b-1b25-4aab-824c-2f2c8a209c73",
                            Age = 32,
                            Name = "Ali 2",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9580)
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("WebApplication03.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication03.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("WebApplication03.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplication03.Models.ApplicationUser", null)
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

                    b.HasOne("WebApplication03.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApplication03.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication03.Models.City", b =>
                {
                    b.HasOne("WebApplication03.Models.Country", "Country")
                        .WithMany("cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebApplication03.Models.Person", b =>
                {
                    b.HasOne("WebApplication03.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("WebApplication03.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("WebApplication03.Models.Country", b =>
                {
                    b.Navigation("cities");
                });
#pragma warning restore 612, 618
        }
    }
}