﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldCup.Infra.Data.Context;

#nullable disable

namespace WorldCup.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221222141639_SeedFootballClubs")]
    partial class SeedFootballClubs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorldCup.Domain.Entities.CupTitle", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("ChampionFootballClubId")
                        .HasColumnType("int");

                    b.Property<int>("CupYear")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ChampionFootballClubId");

                    b.ToTable("CupTitles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CupYear = 1930,
                            Location = "Uruguay"
                        },
                        new
                        {
                            Id = 2,
                            CupYear = 2014,
                            Location = "Brazil"
                        },
                        new
                        {
                            Id = 3,
                            CupYear = 2022,
                            Location = "Qatar"
                        });
                });

            modelBuilder.Entity("WorldCup.Domain.Entities.FootballClub", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FootballClubs");
                });

            modelBuilder.Entity("WorldCup.Domain.Entities.CupTitle", b =>
                {
                    b.HasOne("WorldCup.Domain.Entities.FootballClub", "ChampionFootballClub")
                        .WithMany("CupTitles")
                        .HasForeignKey("ChampionFootballClubId");

                    b.Navigation("ChampionFootballClub");
                });

            modelBuilder.Entity("WorldCup.Domain.Entities.FootballClub", b =>
                {
                    b.Navigation("CupTitles");
                });
#pragma warning restore 612, 618
        }
    }
}
