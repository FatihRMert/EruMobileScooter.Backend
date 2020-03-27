﻿// <auto-generated />
using System;
using EruMobileScooter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EruMobileScooter.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EruMobileScooter.Data.ActiveScooter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ScooterId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ScooterId");

                    b.HasIndex("UserId");

                    b.ToTable("ActiveScooters");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyGenerator", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentEnergy")
                        .HasColumnType("integer");

                    b.Property<int>("EnergyCapacity")
                        .HasColumnType("integer");

                    b.Property<string>("EnergyStationId")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EnergyStationId");

                    b.ToTable("EnergyGenerators");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyStation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("CurrentEnergy")
                        .HasColumnType("double precision");

                    b.Property<double>("EnergyCapacity")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("EnergyStations");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ScooterTransportHistoryId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ScooterTransportHistoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Scooter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Barcode")
                        .HasColumnType("text");

                    b.Property<int>("ChargeState")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentRange")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("MaxRange")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Scooters");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterStation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentCapacity")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("ScooterStations");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterTransportHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FromStationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("FromStationOutTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ScooterId")
                        .HasColumnType("text");

                    b.Property<string>("ToStationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("ToStationInTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FromStationId");

                    b.HasIndex("ScooterId");

                    b.HasIndex("ToStationId");

                    b.HasIndex("UserId");

                    b.ToTable("ScooterTransportHistories");
                });

            modelBuilder.Entity("EruMobileScooter.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Department")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Faculty")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Identity")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isBanned")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ActiveScooter", b =>
                {
                    b.HasOne("EruMobileScooter.Data.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyGenerator", b =>
                {
                    b.HasOne("EruMobileScooter.Data.EnergyStation", null)
                        .WithMany("EnergyGenerators")
                        .HasForeignKey("EnergyStationId");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Payment", b =>
                {
                    b.HasOne("EruMobileScooter.Data.ScooterTransportHistory", "ScooterTransportHistory")
                        .WithMany()
                        .HasForeignKey("ScooterTransportHistoryId");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterTransportHistory", b =>
                {
                    b.HasOne("EruMobileScooter.Data.ScooterStation", "FromStation")
                        .WithMany()
                        .HasForeignKey("FromStationId");

                    b.HasOne("EruMobileScooter.Data.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId");

                    b.HasOne("EruMobileScooter.Data.ScooterStation", "ToStation")
                        .WithMany()
                        .HasForeignKey("ToStationId");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
