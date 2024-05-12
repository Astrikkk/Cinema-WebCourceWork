﻿using CinemaDataBase.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaDataBase.Data
{
    public class CinemaDBContext : IdentityDbContext
    {

        public CinemaDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Film> Films { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seat>().HasData(new[]
            {
                new Seat() { id = 1, Row = 1, Column = 1 , IsOccupied = false},
                new Seat() { id = 2, Row = 1, Column = 2 , IsOccupied = false },
                new Seat() { id = 3, Row = 1, Column = 3 , IsOccupied = false },
                new Seat() { id = 4, Row = 1, Column = 4 , IsOccupied = false },
                new Seat() { id = 5, Row = 1, Column = 5 , IsOccupied = false },
                new Seat() { id = 6, Row = 2, Column = 1 , IsOccupied = false },
                new Seat() { id = 7, Row = 2, Column = 2 , IsOccupied = false },
                new Seat() { id = 8, Row = 2, Column = 3 , IsOccupied = false },
                new Seat() { id = 9, Row = 2, Column = 4 , IsOccupied = false },
                new Seat() { id = 10, Row = 2, Column = 5 , IsOccupied = false },
                new Seat() { id = 11, Row = 3, Column = 1 , IsOccupied = false },
                new Seat() { id = 12, Row = 3, Column = 2 , IsOccupied = false },
                new Seat() { id = 13, Row = 3, Column = 3 , IsOccupied = false },
                new Seat() { id = 14, Row = 3, Column = 4 , IsOccupied = false },
                new Seat() { id = 15, Row = 3, Column = 5 , IsOccupied = false },
                new Seat() { id = 16, Row = 4, Column = 1 , IsOccupied = false },
                new Seat() { id = 17, Row = 4, Column = 2 , IsOccupied = false },
                new Seat() { id = 18, Row = 4, Column = 3 , IsOccupied = false },
                new Seat() { id = 19, Row = 4, Column = 4 , IsOccupied = false },
                new Seat() { id = 20, Row = 4, Column = 5 , IsOccupied = false }
            });

            modelBuilder.Entity<Film>().HasData(new[]
            {
                new Film() { Id = 1, Name = "The Truman Show", Genre = "Drama", Description = "The story of a man who lives in a fictional world controlled by a television station.", ReleaseDate = new DateTime(1998, 6, 5), ShowTime = new DateTime(2024, 5, 7, 18, 30, 0) },
                new Film() { Id = 2, Name = "Green Book", Genre = "Drama", Description = "An African-American pianist and his Italian-American chauffeur travel through the Southern states in the 1960s and develop an unlikely friendship.", ReleaseDate = new DateTime(2018, 11, 16), ShowTime = new DateTime(2024, 5, 7, 20, 0, 0) },
                new Film() { Id = 3, Name = "Star Wars: Episode IV - A New Hope", Genre = "Action, Adventure, Fantasy", Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", ReleaseDate = new DateTime(1977, 5, 25), ShowTime = new DateTime(2024, 5, 7, 15, 0, 0) },
                new Film() { Id = 4, Name = "The Shawshank Redemption", Genre = "Drama", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", ReleaseDate = new DateTime(1994, 10, 14), ShowTime = new DateTime(2024, 5, 7, 17, 30, 0) },
                new Film() { Id = 5, Name = "The Godfather", Genre = "Crime, Drama", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", ReleaseDate = new DateTime(1972, 3, 24), ShowTime = new DateTime(2024, 5, 7, 19, 0, 0) },
                new Film() { Id = 6, Name = "The Dark Knight", Genre = "Action, Crime, Drama", Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.", ReleaseDate = new DateTime(2008, 7, 18), ShowTime = new DateTime(2024, 5, 7, 21, 30, 0) },
                new Film() { Id = 7, Name = "Pulp Fiction", Genre = "Crime, Drama", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", ReleaseDate = new DateTime(1994, 10, 14), ShowTime = new DateTime(2024, 5, 7, 22, 0, 0) },
                new Film() { Id = 8, Name = "Forrest Gump", Genre = "Drama, Romance", Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", ReleaseDate = new DateTime(1994, 7, 6), ShowTime = new DateTime(2024, 5, 7, 12, 0, 0) },
                new Film() { Id = 9, Name = "Inception", Genre = "Action, Adventure, Sci-Fi", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", ReleaseDate = new DateTime(2010, 7, 16), ShowTime = new DateTime(2024, 5, 7, 13, 0, 0) },
                new Film() { Id = 10, Name = "The Matrix", Genre = "Action, Sci-Fi", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", ReleaseDate = new DateTime(1999, 3, 31), ShowTime = new DateTime(2024, 5, 7, 14, 30, 0) },
            });

            modelBuilder.Entity<Film>()
                .HasMany(f => f.Seats)
                .WithOne()
                .HasForeignKey("FilmId")
                .IsRequired();
        }

    }
}