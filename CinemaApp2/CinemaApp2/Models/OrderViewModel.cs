namespace CinemaApp2.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public int Seats { get; set; }
        public string FilmName { get; set; }
        public string HallName { get; set; }
        public DateTime ShowTime { get; set; }
        public decimal Price { get; set; }
    }
}
