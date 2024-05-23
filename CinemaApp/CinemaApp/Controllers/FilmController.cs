using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
