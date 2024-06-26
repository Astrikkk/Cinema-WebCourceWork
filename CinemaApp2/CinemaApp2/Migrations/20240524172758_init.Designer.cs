﻿// <auto-generated />
using System;
using CinemaApp2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaApp2.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20240524172758_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaApp2.Data.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The story of a man who lives in a fictional world controlled by a television station.",
                            Genre = "Drama",
                            Name = "The Truman Show",
                            ReleaseDate = new DateTime(1998, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "An African-American pianist and his Italian-American chauffeur travel through the Southern states in the 1960s and develop an unlikely friendship.",
                            Genre = "Drama",
                            Name = "Green Book",
                            ReleaseDate = new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.",
                            Genre = "Action, Adventure, Fantasy",
                            Name = "Star Wars: Episode IV - A New Hope",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Genre = "Drama",
                            Name = "The Shawshank Redemption",
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Genre = "Crime, Drama",
                            Name = "The Godfather",
                            ReleaseDate = new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Genre = "Action, Crime, Drama",
                            Name = "The Dark Knight",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Genre = "Crime, Drama",
                            Name = "Pulp Fiction",
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                            Genre = "Drama, Romance",
                            Name = "Forrest Gump",
                            ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                            Genre = "Action, Adventure, Sci-Fi",
                            Name = "Inception",
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                            Genre = "Action, Sci-Fi",
                            Name = "The Matrix",
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CinemaApp2.Data.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FilmId = 1,
                            ShowTime = new DateTime(2024, 5, 31, 18, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            FilmId = 2,
                            ShowTime = new DateTime(2024, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            FilmId = 3,
                            ShowTime = new DateTime(2024, 6, 1, 20, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            FilmId = 4,
                            ShowTime = new DateTime(2024, 6, 21, 18, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CinemaApp2.Data.Entities.Session", b =>
                {
                    b.HasOne("CinemaApp2.Data.Entities.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });
#pragma warning restore 612, 618
        }
    }
}
