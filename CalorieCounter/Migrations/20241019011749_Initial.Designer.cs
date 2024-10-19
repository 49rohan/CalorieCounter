﻿// <auto-generated />
using System;
using CalorieCounter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalorieCounter.Migrations
{
    [DbContext(typeof(CalorieDBContext))]
    [Migration("20241019011749_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CalorieCounter.Models.Calorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Calories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 105,
                            Name = "Banana"
                        },
                        new
                        {
                            Id = 2,
                            Calories = 95,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            Calories = 45,
                            Name = "Orange"
                        },
                        new
                        {
                            Id = 4,
                            Calories = 563,
                            Name = "Big Mac"
                        },
                        new
                        {
                            Id = 5,
                            Calories = 140,
                            Name = "Takis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
