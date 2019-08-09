﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeaTracker.Data;

namespace TeaTracker.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190809185914_Unit_Change")]
    partial class Unit_Change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeaTracker.Data.Entities.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CupSize");

                    b.Property<DateTime>("DrinkTime");

                    b.Property<int>("DrinkType");

                    b.Property<int>("VolumeUnit");

                    b.HasKey("HistoryId");

                    b.ToTable("History","core");
                });
#pragma warning restore 612, 618
        }
    }
}
