namespace CinemaDataBase.Data.Entities
{
    public class Seans
    {
        public int Id { get; set; }
        public DateTime ShowTime { get; set; }
        public int FilmId { get; set; }
        public Film? Film { get; set; }
        public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
}