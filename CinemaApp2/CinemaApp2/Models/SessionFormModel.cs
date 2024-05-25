using CinemaApp2.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace CinemaApp2.Models
{
    public class SessionFormModel
    {
        public int Id { get; set; }
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        //[CustomValidation(typeof(ValidationHelper), nameof(ValidationHelper.ValidateShowTime))]
        public DateTime ShowTime { get; set; }
        [Range(1, int.MaxValue)]
        public int FilmId { get; set; }
        public int HallId { get; set; }
    }
}
