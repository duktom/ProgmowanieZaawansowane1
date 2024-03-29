﻿// <auto-generated />
using System;
using AdvancedProgramming_Lesson1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedProgramming_Lesson1.Migrations.MvcTree
{
    [DbContext(typeof(MvcTreeContext))]
    [Migration("20230408165422_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedProgramming_Lesson1.Models.Tree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Diameter")
                        .HasColumnType("float");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LeafColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PlantDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TreeType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tree");
                });
#pragma warning restore 612, 618
        }
    }
}
