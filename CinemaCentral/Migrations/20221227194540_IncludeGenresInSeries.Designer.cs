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
    [Migration("20221227194540_IncludeGenresInSeries")]
    partial class IncludeGenresInSeries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("CinemaCentral.Models.Episode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SeasonId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SeriesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("SeriesId");

                    b.ToTable("Episodes");
                });

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

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPath")
                        .IsRequired()
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

            modelBuilder.Entity("CinemaCentral.Models.Season", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PosterPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SeriesId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("CinemaCentral.Models.Series", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("CommunityRating")
                        .HasColumnType("REAL");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TmdbId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("CinemaCentral.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f807c6f7-3825-43c4-b48e-db0eb5928b58"),
                            Name = "user",
                            PasswordHash = new byte[] { 101, 6, 129, 237, 185, 234, 68, 69, 246, 188, 150, 234, 135, 151, 133, 106, 110, 213, 140, 187, 116, 162, 197, 33, 194, 233, 97, 9, 174, 47, 147, 92, 233, 227, 153, 170, 148, 183, 183, 219, 212, 248, 9, 129, 233, 73, 44, 103, 109, 68, 50, 195, 164, 136, 224, 193, 164, 129, 187, 99, 173, 200, 249, 23, 182, 223, 63, 82, 90, 75, 27, 227, 200, 2, 122, 161, 49, 72, 138, 102, 120, 7, 167, 83, 179, 107, 100, 77, 115, 127, 217, 52, 188, 30, 150, 1, 109, 7, 6, 188, 214, 11, 2, 246, 70, 223, 100, 29, 14, 172, 58, 154, 221, 16, 229, 183, 28, 57, 15, 230, 38, 152, 173, 165, 72, 160, 104, 147 },
                            PasswordSalt = new byte[] { 21, 117, 195, 114, 132, 27, 168, 103, 228, 95, 122, 60, 45, 31, 202, 2, 221, 116, 100, 40, 9, 62, 20, 94, 91, 75, 63, 33, 0, 255, 154, 32 },
                            Role = 0
                        });
                });

            modelBuilder.Entity("CinemaCentral.Models.WatchtimeStamp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EpisodeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EpisodeId");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("WatchtimeStamps");
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

            modelBuilder.Entity("GenreSeries", b =>
                {
                    b.Property<string>("GenresName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SeriesId")
                        .HasColumnType("TEXT");

                    b.HasKey("GenresName", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("GenreSeries");
                });

            modelBuilder.Entity("CinemaCentral.Models.Episode", b =>
                {
                    b.HasOne("CinemaCentral.Models.Season", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaCentral.Models.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("CinemaCentral.Models.Season", b =>
                {
                    b.HasOne("CinemaCentral.Models.Series", "Series")
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("CinemaCentral.Models.WatchtimeStamp", b =>
                {
                    b.HasOne("CinemaCentral.Models.Episode", "Episode")
                        .WithMany("WatchtimeStamps")
                        .HasForeignKey("EpisodeId");

                    b.HasOne("CinemaCentral.Models.Movie", "Movie")
                        .WithMany("WatchtimeStamps")
                        .HasForeignKey("MovieId");

                    b.HasOne("CinemaCentral.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");

                    b.Navigation("Movie");

                    b.Navigation("User");
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

            modelBuilder.Entity("GenreSeries", b =>
                {
                    b.HasOne("CinemaCentral.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaCentral.Models.Series", null)
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaCentral.Models.Episode", b =>
                {
                    b.Navigation("WatchtimeStamps");
                });

            modelBuilder.Entity("CinemaCentral.Models.Movie", b =>
                {
                    b.Navigation("WatchtimeStamps");
                });

            modelBuilder.Entity("CinemaCentral.Models.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("CinemaCentral.Models.Series", b =>
                {
                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
