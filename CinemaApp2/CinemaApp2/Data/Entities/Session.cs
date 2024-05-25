namespace CinemaApp2.Data.Entities
{
    public class Session
    {
        public int Id {  get; set; }
        public int Price { get; set; }
        public DateTime ShowTime { get; set; }
        public int OccupiedSeats { get; set; }
        public int FilmId { get; set; }
        public Film? Film { get; set; }
        public int HallId { get; set; }
        public Hall? Hall { get; set; }
    }
}
