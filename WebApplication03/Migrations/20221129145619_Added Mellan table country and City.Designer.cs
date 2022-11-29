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
    [Migration("20221129145619_Added Mellan table country and City")]
    partial class AddedMellantablecountryandCity
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
                            Id = "1d2d45a3-06f6-439b-870d-beb4014f9ac1",
                            Name = "GBG",
                            PostNumber = "415 52",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9728)
                        },
                        new
                        {
                            Id = "23c17856-95b3-4318-946e-4c3b60d8d2b2",
                            Name = "Järpen",
                            PostNumber = "415 55",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9733)
                        },
                        new
                        {
                            Id = "21fc0b1a-09f7-44c9-8d1d-331a6452b1ed",
                            Name = "Mörsil",
                            PostNumber = "415 44",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9737)
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
                            Id = "73b9792f-73b8-4bd9-9a9e-3efec0d09f0f",
                            Name = "Sweden",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9759)
                        },
                        new
                        {
                            Id = "27606428-2a0d-4045-a271-4cde453b2555",
                            Name = "Norway",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9764)
                        },
                        new
                        {
                            Id = "1c7ea0d7-d579-44aa-9a9b-6252bff20d05",
                            Name = "Danmarc",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9768)
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
                            Id = "fd5db384-3a4a-4c0c-9c72-c2acc3443c0c",
                            Name = "Svenska",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9419)
                        },
                        new
                        {
                            Id = "d815419f-22e1-4e01-8058-2f72ffae52d6",
                            Name = "Persiska",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9460)
                        },
                        new
                        {
                            Id = "f635cb16-9c0d-4d17-a13d-3d4613e2b89f",
                            Name = "Engleska",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9465)
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
                            Id = "3cf1092a-2ba7-4af4-8376-01a51fb7e5f1",
                            Age = 32,
                            Name = "Ali",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9595)
                        },
                        new
                        {
                            Id = "78d1df8c-87a9-497d-967d-4f9cccf6a79a",
                            Age = 32,
                            Name = "Ali 1",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9601)
                        },
                        new
                        {
                            Id = "37d63494-4739-4a2d-8888-37112b548dff",
                            Age = 32,
                            Name = "Ali 2",
                            PhoneNumber = "123456",
                            Register = new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9707)
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
                    b.HasOne("WebApplication03.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("WebApplication03.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
