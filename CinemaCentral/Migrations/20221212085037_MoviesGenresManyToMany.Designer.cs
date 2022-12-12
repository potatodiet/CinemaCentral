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
    [Migration("20221212085037_MoviesGenresManyToMany")]
    partial class MoviesGenresManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("CinemaCentral.Models.Genre", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Genres");
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

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<string>("GenresName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("TEXT");

                    b.HasKey("GenresName", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("CinemaCentral.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaCentral.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
