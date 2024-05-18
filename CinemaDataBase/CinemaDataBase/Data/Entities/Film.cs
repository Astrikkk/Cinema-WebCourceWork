namespace CinemaDataBase.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}