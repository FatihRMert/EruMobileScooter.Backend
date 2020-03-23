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
    [Migration("20200323123858_Changed Table Name EnergyGenerators and ScooterTransportHistory")]
    partial class ChangedTableNameEnergyGeneratorsandScooterTransportHistory
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
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ScooterId")
                        .HasColumnName("scooter_id")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_active_scooters");

                    b.HasIndex("ScooterId")
                        .HasName("ix_active_scooters_scooter_id");

                    b.HasIndex("UserId")
                        .HasName("ix_active_scooters_user_id");

                    b.ToTable("active_scooters");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyGenerator", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentEnergy")
                        .HasColumnName("current_energy")
                        .HasColumnType("integer");

                    b.Property<int>("EnergyCapacity")
                        .HasColumnName("energy_capacity")
                        .HasColumnType("integer");

                    b.Property<string>("EnergyStationId")
                        .HasColumnName("energy_station_id")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnName("type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_energy_generators");

                    b.HasIndex("EnergyStationId")
                        .HasName("ix_energy_generators_energy_station_id");

                    b.ToTable("energy_generators");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyStation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("CurrentEnergy")
                        .HasColumnName("current_energy")
                        .HasColumnType("double precision");

                    b.Property<double>("EnergyCapacity")
                        .HasColumnName("energy_capacity")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_energy_stations");

                    b.ToTable("energy_stations");
                });

            modelBuilder.Entity("EruMobileScooter.Data.Scooter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<string>("Barcode")
                        .HasColumnName("barcode")
                        .HasColumnType("text");

                    b.Property<int>("ChargeState")
                        .HasColumnName("charge_state")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentRange")
                        .HasColumnName("current_range")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.Property<int>("MaxRange")
                        .HasColumnName("max_range")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnName("number")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_scooters");

                    b.ToTable("scooters");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterStation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrentCapacity")
                        .HasColumnName("current_capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.Property<int>("MaxCapacity")
                        .HasColumnName("max_capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("pk_scooter_stations");

                    b.ToTable("scooter_stations");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterTransportHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FromStationId")
                        .HasColumnName("from_station_id")
                        .HasColumnType("text");

                    b.Property<DateTime>("FromStationOutTime")
                        .HasColumnName("from_station_out_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ScooterId")
                        .HasColumnName("scooter_id")
                        .HasColumnType("text");

                    b.Property<string>("ToStationId")
                        .HasColumnName("to_station_id")
                        .HasColumnType("text");

                    b.Property<DateTime>("ToStationInTime")
                        .HasColumnName("to_station_in_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_scooter_transport_histories");

                    b.HasIndex("FromStationId")
                        .HasName("ix_scooter_transport_histories_from_station_id");

                    b.HasIndex("ScooterId")
                        .HasName("ix_scooter_transport_histories_scooter_id");

                    b.HasIndex("ToStationId")
                        .HasName("ix_scooter_transport_histories_to_station_id");

                    b.HasIndex("UserId")
                        .HasName("ix_scooter_transport_histories_user_id");

                    b.ToTable("scooter_transport_histories");
                });

            modelBuilder.Entity("EruMobileScooter.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Department")
                        .HasColumnName("department")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("Faculty")
                        .HasColumnName("faculty")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("integer");

                    b.Property<string>("Identity")
                        .HasColumnName("identity")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnName("role")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnName("surname")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isBanned")
                        .HasColumnName("is_banned")
                        .HasColumnType("boolean");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ActiveScooter", b =>
                {
                    b.HasOne("EruMobileScooter.Data.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId")
                        .HasConstraintName("fk_active_scooters_scooters_scooter_id");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_active_scooters_users_user_id");
                });

            modelBuilder.Entity("EruMobileScooter.Data.EnergyGenerator", b =>
                {
                    b.HasOne("EruMobileScooter.Data.EnergyStation", null)
                        .WithMany("EnergyCreators")
                        .HasForeignKey("EnergyStationId")
                        .HasConstraintName("fk_energy_generators_energy_stations_energy_station_id");
                });

            modelBuilder.Entity("EruMobileScooter.Data.ScooterTransportHistory", b =>
                {
                    b.HasOne("EruMobileScooter.Data.ScooterStation", "FromStation")
                        .WithMany()
                        .HasForeignKey("FromStationId")
                        .HasConstraintName("fk_scooter_transport_histories_scooter_stations_from_station_id");

                    b.HasOne("EruMobileScooter.Data.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId")
                        .HasConstraintName("fk_scooter_transport_histories_scooters_scooter_id");

                    b.HasOne("EruMobileScooter.Data.ScooterStation", "ToStation")
                        .WithMany()
                        .HasForeignKey("ToStationId")
                        .HasConstraintName("fk_scooter_transport_histories_scooter_stations_to_station_id");

                    b.HasOne("EruMobileScooter.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_scooter_transport_histories_users_user_id");
                });
#pragma warning restore 612, 618
        }
    }
}
