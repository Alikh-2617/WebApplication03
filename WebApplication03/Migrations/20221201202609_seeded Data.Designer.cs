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
    [Migration("20221201202609_seeded Data")]
    partial class seededData
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
                            LanguagesId = "e6dbf485-c2a6-40bf-ac55-3667cafa4c39",
                            PeopleId = "f5522beb-c267-4461-8d7c-53e2246adc5a"
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
                            Id = "e27cbb32-ff29-4884-a94c-8b7b60bc2b2f",
                            Name = "GBG",
                            PostNumber = "415 52",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9989)
                        },
                        new
                        {
                            Id = "552443b2-6831-4720-8023-43f843fa1d9f",
                            Name = "Järpen",
                            PostNumber = "415 55",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9994)
                        },
                        new
                        {
                            Id = "b4b589b9-e05b-41e7-a706-1cb2751d0beb",
                            Name = "Mörsil",
                            PostNumber = "415 44",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9998)
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
                            Id = "0b6fdd2f-e148-4b35-aa63-5b863359821a",
                            Name = "Sweden",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(20)
                        },
                        new
                        {
                            Id = "5c97ca1e-d39a-4958-9d88-c37f62bbff81",
                            Name = "Norway",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(27)
                        },
                        new
                        {
                            Id = "aaeceb46-e21a-4904-aa61-e5f802ca0890",
                            Name = "Danmarc",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(32)
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
                            Id = "e6dbf485-c2a6-40bf-ac55-3667cafa4c39",
                            Name = "Svenska",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9013)
                        },
                        new
                        {
                            Id = "ebdc3afb-727b-4e94-a70e-d5589a810f47",
                            Name = "Svenska",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9915)
                        },
                        new
                        {
                            Id = "964212fe-169e-47d7-b581-dd91fd5d153b",
                            Name = "Persiska",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9925)
                        },
                        new
                        {
                            Id = "883e5698-b1a8-4ea7-819f-4a5079df4949",
                            Name = "Engleska",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9940)
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
                            Id = "f5522beb-c267-4461-8d7c-53e2246adc5a",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9082)
                        },
                        new
                        {
                            Id = "f1cbc93c-af18-4d05-ab0e-e39fd146e32f",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9963)
                        },
                        new
                        {
                            Id = "7c544e13-ff95-42bd-9d98-4fc006fda9f8",
                            Age = 32,
                            Name = "Ali 1",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9968)
                        },
                        new
                        {
                            Id = "2163f1c3-18b9-4273-b25b-eb4b45b0fd49",
                            Age = 32,
                            Name = "Ali 2",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9972)
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