namespace CinemaDataBase.Data.Entities
{
    public class Seat
    {
        public int id { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }

        public bool IsOccupied;
    }
}
