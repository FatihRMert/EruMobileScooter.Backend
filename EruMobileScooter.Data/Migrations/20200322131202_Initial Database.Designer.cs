﻿// <auto-generated />
using System;
using EruMobileScooter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EruMobileScooter.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200322131202_Initial Database")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("EruMobileScooter.Data.EnergyCreator", b =>
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

                    b.ToTable("EnergyCreators");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyStation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentEnergy")
                        .HasColumnType("integer");

                    b.Property<int>("EnergyCapacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("EnergyStations");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Scooter", b =>
                {
                    b.Property<string>("Id")
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

                    b.Property<string>("ScooterStationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ScooterStationId");

                    b.ToTable("Scooters");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ScooterId")
                        .HasColumnType("text");

                    b.Property<string>("ScooterStationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ScooterId");

                    b.HasIndex("ScooterStationId");

                    b.HasIndex("UserId");

                    b.ToTable("ScooterHistories");
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

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

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

            modelBuilder.Entity("EruMobileScooter.Data.EnergyCreator", b =>
                {
                    b.HasOne("EruMobileScooter.Data.EnergyStation", null)
                        .WithMany("EnergyCreators")
                        .HasForeignKey("EnergyStationId");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Scooter", b =>
                {
                    b.HasOne("EruMobileScooter.Data.ScooterStation", "ScooterStation")
                        .WithMany("Scooters")
                        .HasForeignKey("ScooterStationId");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterHistory", b =>
                {
                    b.HasOne("EruMobileScooter.Data.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId");

                    b.HasOne("EruMobileScooter.Data.ScooterStation", "ScooterStation")
                        .WithMany()
                        .HasForeignKey("ScooterStationId");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
