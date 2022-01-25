﻿// <auto-generated />
using System;
using DioSeriesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DioSeriesWebMvc.Migrations
{
    [DbContext(typeof(DioSeriesWebMvcContext))]
    partial class DioSeriesWebMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DioSeriesWebMvc.Models.GymDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GymDepartment");
                });

            modelBuilder.Entity("DioSeriesWebMvc.Models.Gymming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("Categorie");

                    b.Property<string>("Email");

                    b.Property<int?>("GymDepartmentId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GymDepartmentId");

                    b.ToTable("Gymming");
                });

            modelBuilder.Entity("DioSeriesWebMvc.Models.GymmingRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("GymmingId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("GymmingId");

                    b.ToTable("GymmingRecord");
                });

            modelBuilder.Entity("DioSeriesWebMvc.Models.Gymming", b =>
                {
                    b.HasOne("DioSeriesWebMvc.Models.GymDepartment", "GymDepartment")
                        .WithMany("Gymmings")
                        .HasForeignKey("GymDepartmentId");
                });

            modelBuilder.Entity("DioSeriesWebMvc.Models.GymmingRecord", b =>
                {
                    b.HasOne("DioSeriesWebMvc.Models.Gymming", "Gymming")
                        .WithMany("Gym")
                        .HasForeignKey("GymmingId");
                });
#pragma warning restore 612, 618
        }
    }
}
