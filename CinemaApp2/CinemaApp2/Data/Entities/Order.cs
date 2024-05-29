using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CinemaApp2.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Required]
        [Phone]
        public string CustomerPhone { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Seats must be at least 1.")]
        public int Seats { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        [Required]
        public int UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
