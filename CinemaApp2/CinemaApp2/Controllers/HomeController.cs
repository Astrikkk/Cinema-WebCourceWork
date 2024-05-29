using AutoMapper;
using CinemaApp2.Data;
using CinemaApp2.Data.Entities;
using CinemaApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CinemaApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CinemaDbContext context;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, CinemaDbContext context, IMapper mapper)
        {
            _logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var sessions = context.Sessions.Include(x => x.Film).Include(x => x.Hall).ToList();
            var films = context.Films.Include(x => x.Genre).ToList();

            var viewModel = new SessionsAndFilmsViewModel
            {
                Sessions = sessions,
                Films = films
            };

            return View(viewModel);

        }

        [HttpGet]
        public IActionResult BookSession(int id)
        {
            var session = context.Sessions
                                 .Include(s => s.Film)
                                 .ThenInclude(f => f.Genre)
                                 .Include(s => s.Hall)
                                 .FirstOrDefault(s => s.Id == id);

            if (session == null)
            {
                return NotFound();
            }

            var viewModel = new SessionAndOrder
            {
                Session = session,
                Order = new Order()  // Initialize a new Order
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BookSession(int id, SessionAndOrder viewModel)
        {
            var session = context.Sessions
                                 .Include(s => s.Film)
                                 .ThenInclude(f => f.Genre)
                                 .Include(s => s.Hall)
                                 .FirstOrDefault(s => s.Id == id);

            if (session == null)
            {
                return NotFound();
            }

            // Associate the order with the session
            viewModel.Order.SessionId = session.Id;

            session.OccupiedSeats += viewModel.Order.Seats;
            // Save the order to the database
            context.Orders.Add(viewModel.Order);
            context.SaveChanges();
            // Redirect to BookingConfirmation action
            return RedirectToAction("BookingConfirmation", new { id = session.Id });


            //viewModel.Session = context.Sessions
            //                            .Include(s => s.Film)
            //                            .ThenInclude(f => f.Genre)
            //                            .Include(s => s.Hall)
            //                            .FirstOrDefault(s => s.Id == id);
            //return View(viewModel);
        }



        public IActionResult BookingConfirmation(int id)
        {
            var session = context.Sessions
                                 .Include(s => s.Film)
                                 .Include(s => s.Hall)
                                 .FirstOrDefault(s => s.Id == id);

            if (session == null)
            {
                return NotFound();
            }

            var order = context.Orders
                               .Where(o => o.SessionId == id)
                               .OrderByDescending(o => o.Id)
                               .FirstOrDefault();

            if (order == null)
            {
                return NotFound();
            }

            var viewModel = new SessionAndOrder
            {
                Session = session,
                Order = order
            };

            return View(viewModel);
        }



        [HttpGet]
        public IActionResult SessionObserve(int id)
        {
            var session = context.Sessions
                                .Include(s => s.Film)
                                .Include(s => s.Hall)
                                .FirstOrDefault(s => s.Id == id);

            if (session == null)
            {
                return NotFound();
            }

            var films = context.Films.Include(f => f.Genre).ToList();

            var viewModel = new SessionsAndFilmsViewModel
            {
                Sessions = new List<Session> { session },
                Films = films
            };

            return View(viewModel);
        }
        public IActionResult FilmObserve(int id)
        {
            var film = context.Films.Include(f => f.Genre).FirstOrDefault(f => f.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film); // Ensure you're passing a single Film object
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
