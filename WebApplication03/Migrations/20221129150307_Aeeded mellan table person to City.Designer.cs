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
    [Migration("20221129150307_Aeeded mellan table person to City")]
    partial class AeededmellantablepersontoCity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CityCountry", b =>
                {
                    b.Property<string>("CitiesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountriesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CitiesId", "CountriesId");

                    b.HasIndex("CountriesId");

                    b.ToTable("CityCountry");
                });

            modelBuilder.Entity("CityPerson", b =>
                {
                    b.Property<string>("CitiesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PeopleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CitiesId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("CityPerson");
                });

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
                            LanguagesId = "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6",
                            PeopleId = "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a"
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.City", b =>
                {
                    b.Property<string>("Id")
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

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = "4be5ad4d-6b10-4e2c-bcb5-b1883fc28364",
                            Name = "GBG",
                            PostNumber = "415 52",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1608)
                        },
                        new
                        {
                            Id = "39483b94-c0b4-4d44-8659-d677154e544a",
                            Name = "Järpen",
                            PostNumber = "415 55",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1614)
                        },
                        new
                        {
                            Id = "e942d842-0228-4db8-a03a-f7bc9c6459ae",
                            Name = "Mörsil",
                            PostNumber = "415 44",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1619)
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
                            Id = "699e9f36-6d88-41ee-9e22-7f0e7bf3b320",
                            Name = "Sweden",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1693)
                        },
                        new
                        {
                            Id = "fc1022dd-7f8a-48c5-b4d8-ee18b4cc0228",
                            Name = "Norway",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1701)
                        },
                        new
                        {
                            Id = "9208e40c-5896-42fd-934d-3dd6876b00fc",
                            Name = "Danmarc",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1705)
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
                            Id = "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6",
                            Name = "Svenska",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(715)
                        },
                        new
                        {
                            Id = "6f31dec1-68ed-43eb-8879-48fefa9b300e",
                            Name = "Svenska",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1535)
                        },
                        new
                        {
                            Id = "5fa3acd2-10fc-497c-9263-c8cb8e82442a",
                            Name = "Persiska",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1547)
                        },
                        new
                        {
                            Id = "5eb94ff2-e70b-42bf-8235-0b68823539c6",
                            Name = "Engleska",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1563)
                        });
                });

            modelBuilder.Entity("WebApplication03.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(775)
                        },
                        new
                        {
                            Id = "7b4e46c6-eeb9-4348-8b79-9c03e9e0d049",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1579)
                        },
                        new
                        {
                            Id = "0f911629-8b2a-45e0-b992-02bf00de2501",
                            Age = 32,
                            Name = "Ali 1",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1583)
                        },
                        new
                        {
                            Id = "6d08ef9c-ee82-4118-9d91-1c61e2f1514a",
                            Age = 32,
                            Name = "Ali 2",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1587)
                        });
                });

            modelBuilder.Entity("CityCountry", b =>
                {
                    b.HasOne("WebApplication03.Models.City", null)
                        .WithMany()
                        .HasForeignKey("CitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication03.Models.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CityPerson", b =>
                {
                    b.HasOne("WebApplication03.Models.City", null)
                        .WithMany()
                        .HasForeignKey("CitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication03.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
#pragma warning restore 612, 618
        }
    }
}
