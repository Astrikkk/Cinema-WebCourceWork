using CinemaApp2.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp2.Data
{
    public class CinemaDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    optionsBuilder.UseSqlServer(connStr);
        //}
        public CinemaDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Film>().HasData(new[]
            {
                new Film { Id = 1, Name = "The Truman Show", GenreId = 1, Description = "The story of a man who lives in a fictional world controlled by a television station.", ReleaseDate = new DateTime(1998, 6, 5)},
                new Film { Id = 2, Name = "Green Book", GenreId = 1, Description = "An African-American pianist and his Italian-American chauffeur travel through the Southern states in the 1960s and develop an unlikely friendship.", ReleaseDate = new DateTime(2018, 11, 16) },
                new Film { Id = 3, Name = "Star Wars: Episode IV - A New Hope", GenreId = 2, Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", ReleaseDate = new DateTime(1977, 5, 25) },
                new Film { Id = 4, Name = "The Shawshank Redemption", GenreId = 1, Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", ReleaseDate = new DateTime(1994, 10, 14) },
                new Film { Id = 5, Name = "The Godfather", GenreId = 5, Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", ReleaseDate = new DateTime(1972, 3, 24) },
                new Film { Id = 6, Name = "The Dark Knight", GenreId = 2, Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.", ReleaseDate = new DateTime(2008, 7, 18) },
                new Film { Id = 7, Name = "Pulp Fiction", GenreId = 5, Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", ReleaseDate = new DateTime(1994, 10, 14) },
                new Film { Id = 8, Name = "Forrest Gump", GenreId = 1, Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", ReleaseDate = new DateTime(1994, 7, 6) },
                new Film { Id = 9, Name = "Inception", GenreId = 7, Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", ReleaseDate = new DateTime(2010, 7, 16) },
                new Film { Id = 10, Name = "The Matrix", GenreId = 7, Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", ReleaseDate = new DateTime(1999, 3, 31) },
            });

            modelBuilder.Entity<Session>().HasData(new[]
            {
                new Session() {Id = 1, FilmId = 1, ShowTime = new DateTime(2024, 5, 31, 18, 30, 0), Price = 100, HallId = 1},
                new Session() {Id = 2, FilmId = 2, ShowTime = new DateTime(2024, 6, 1, 18, 30, 0), Price = 120, HallId = 2},
                new Session() {Id = 3, FilmId = 3, ShowTime = new DateTime(2024, 6, 1, 20, 30, 0), Price = 150, HallId = 3},
                new Session() {Id = 4, FilmId = 4, ShowTime = new DateTime(2024, 6, 21, 18, 30, 0), Price = 90, HallId = 3},
            });

            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre { Id = 1, Name = "Drama" },
                new Genre { Id = 2, Name = "Action" },
                new Genre { Id = 3, Name = "Adventure" },
                new Genre { Id = 4, Name = "Fantasy" },
                new Genre { Id = 5, Name = "Crime" },
                new Genre { Id = 6, Name = "Romance" },
                new Genre { Id = 7, Name = "Sci-Fi" },
            });

            modelBuilder.Entity<Hall>().HasData(new[]
            {
                new Hall { Id = 1, Name = "Hall - 1, Action", MaxSeats = 50},
                new Hall { Id = 2, Name = "Hall - 2, Horror", MaxSeats = 50},
                new Hall { Id = 3, Name = "Hall - 1, Midnight", MaxSeats = 70}
            });
        }


        public DbSet<Film> Films { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
