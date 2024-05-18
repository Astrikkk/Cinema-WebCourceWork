namespace CinemaDataBase.Data.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Row { get; set; }
        public bool IsOccupied { get; set; }
        public int SeansId { get; set; }
        public Seans? Seans { get; set; }
    }
}