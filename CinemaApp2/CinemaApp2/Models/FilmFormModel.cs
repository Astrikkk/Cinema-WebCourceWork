using CinemaApp2.Data.Entities;

namespace CinemaApp2.Models
{
    public class FilmFormModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
    }
}
