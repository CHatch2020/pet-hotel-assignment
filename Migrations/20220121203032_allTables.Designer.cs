﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_hotel.Models;

namespace dotnet_bakery.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220121203032_allTables")]
    partial class allTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("breed")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("checkedIn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("color")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("petOwnerId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("petOwnerId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("pet_hotel.PetOwners", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("pets")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("PetOwners");
                });

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.HasOne("pet_hotel.PetOwners", "petOwner")
                        .WithMany()
                        .HasForeignKey("petOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("petOwner");
                });
#pragma warning restore 612, 618
        }
    }
}
