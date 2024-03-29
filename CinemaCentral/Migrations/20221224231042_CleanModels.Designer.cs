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
    [Migration("20221224231042_CleanModels")]
    partial class CleanModels
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

                    b.Property<Guid?>("SeriesId")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("SeriesId");

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
                            PasswordHash = new byte[] { 112, 104, 157, 142, 34, 123, 71, 40, 167, 140, 69, 253, 83, 141, 68, 148, 53, 31, 95, 65, 27, 66, 200, 120, 95, 207, 173, 154, 137, 120, 213, 40, 153, 40, 60, 174, 92, 145, 188, 187, 147, 132, 12, 144, 78, 161, 231, 8, 206, 198, 230, 95, 175, 59, 116, 28, 43, 31, 251, 155, 158, 135, 71, 201, 79, 172, 106, 5, 214, 195, 217, 136, 226, 242, 94, 161, 70, 187, 41, 234, 192, 215, 211, 153, 66, 42, 104, 12, 202, 39, 238, 131, 234, 69, 199, 145, 48, 166, 131, 134, 191, 74, 196, 220, 12, 244, 226, 191, 181, 125, 36, 168, 47, 168, 3, 104, 194, 2, 94, 198, 171, 185, 77, 126, 120, 23, 113, 148 },
                            PasswordSalt = new byte[] { 102, 185, 74, 78, 22, 230, 21, 120, 192, 147, 231, 202, 225, 79, 130, 178, 36, 219, 91, 7, 30, 120, 111, 253, 10, 173, 169, 232, 220, 209, 128, 95 },
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

            modelBuilder.Entity("CinemaCentral.Models.Genre", b =>
                {
                    b.HasOne("CinemaCentral.Models.Series", null)
                        .WithMany("Genres")
                        .HasForeignKey("SeriesId");
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
                    b.Navigation("Genres");

                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
