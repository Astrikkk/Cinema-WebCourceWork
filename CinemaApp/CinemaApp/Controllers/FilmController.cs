using CinemaDataBase.Data;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Controllers
{
    public class FilmController : Controller
    {
        public CinemaDBContext context;

        public FilmController()
        {
            context = new CinemaDBContext();
        }
        public IActionResult Index()
        {
            var films = context.Films.ToList();
            return View(films);
        }
    }
}
