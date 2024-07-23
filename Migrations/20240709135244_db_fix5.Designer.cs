﻿// <auto-generated />
using System;
using MatchdayMadness2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatchdayMadness2.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20240709135244_db_fix5")]
    partial class db_fix5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatchdayMadness2.Models.Favorites", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("FavoritePlayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteTeam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Team_ID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Team_ID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("MatchdayMadness2.Models.Players", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Team_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Team_ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("MatchdayMadness2.Models.Teams", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Coach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Draws")
                        .HasColumnType("int");

                    b.Property<string>("Formation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("League")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Loses")
                        .HasColumnType("int");

                    b.Property<int>("MatchesPlayed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MatchdayMadness2.Models.Favorites", b =>
                {
                    b.HasOne("MatchdayMadness2.Models.Teams", "Teams")
                        .WithMany("Favorites")
                        .HasForeignKey("Team_ID");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("MatchdayMadness2.Models.Players", b =>
                {
                    b.HasOne("MatchdayMadness2.Models.Teams", "Teams")
                        .WithMany("Players")
                        .HasForeignKey("Team_ID");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("MatchdayMadness2.Models.Teams", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
