﻿// <auto-generated />
using AdvancedProgramming_Lesson1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedProgramming_Lesson1.Migrations.MvcKnife
{
    [DbContext(typeof(MvcKnifeContext))]
    partial class MvcKnifeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedProgramming_Lesson1.Models.Knife", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EdgeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lenghtcm")
                        .HasColumnType("float");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sharpness")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Knife");
                });
#pragma warning restore 612, 618
        }
    }
}
