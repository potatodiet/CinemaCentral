﻿// <auto-generated />
using System;
using CinemaCentral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaCentral.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221211203127_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("CinemaCentral.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("CinemaCentral.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("CommunityRating")
                        .HasColumnType("REAL");

                    b.Property<uint>("CurrentWatchTimestamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaCentral.Models.Genre", b =>
                {
                    b.HasOne("CinemaCentral.Models.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CinemaCentral.Models.Movie", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
