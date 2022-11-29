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
    [Migration("20221129144318_Add Person table")]
    partial class AddPersontable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = "55ab194c-eafb-461d-a47d-eb61a9f7031c",
                            Name = "Svenska",
                            Register = new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2480)
                        },
                        new
                        {
                            Id = "13760188-e240-48f4-962f-6cfd9b59c6ea",
                            Name = "Persiska",
                            Register = new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2516)
                        },
                        new
                        {
                            Id = "f6bc00f3-80a6-4a2f-9c11-f8ab292b1899",
                            Name = "Engleska",
                            Register = new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2521)
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
                });
#pragma warning restore 612, 618
        }
    }
}
