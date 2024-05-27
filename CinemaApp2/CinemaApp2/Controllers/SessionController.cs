using AutoMapper;
using CinemaApp2.Data;
using CinemaApp2.Data.Entities;
using CinemaApp2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CinemaApp2.Controllers
{
    public class SessionController : Controller
    {
        private CinemaDbContext context;
        private readonly IMapper mapper;

        public SessionController(CinemaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var sessions = context.Sessions.Include(x => x.Film).Include(x => x.Hall).ToList();

            var currentDateTime = DateTime.Now;
            var ongoingSessions = sessions.Where(s => currentDateTime >= s.ShowTime && currentDateTime <= s.ShowTime.AddHours(2));
            var upcomingSessions = sessions.Where(s => s.ShowTime > currentDateTime);
            var pastSessions = sessions.Where(s => s.ShowTime.AddHours(2) < currentDateTime);

            var sortedSessions = ongoingSessions
                .Concat(upcomingSessions)
                .Concat(pastSessions)
                .ToList();

            var films = context.Films.Include(x => x.Genre).ToList();

            var viewModel = new SessionsAndFilmsViewModel
            {
                Sessions = sortedSessions,
                Films = films
            };

            return View(viewModel);
        }


        public IActionResult FilmObserve()
        {
            var sessions = context.Sessions.Include(x => x.Film).ToList();
            var films = context.Films.Include(x => x.Genre).ToList();

            var viewModel = new SessionsAndFilmsViewModel
            {
                Sessions = sessions,
                Films = films
            };

            return View(viewModel);

        }

        #region Sessions

        [HttpGet] // by default
        public IActionResult Create()
        {
            // ViewBag - transfer data from action to view
            ViewBag.Creation = true;
                LoadHalls();
            LoadFilms();

            return View("Upsert");
        }

        [HttpPost]
        public IActionResult Create(SessionFormModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadHalls();
                LoadFilms();
                ViewBag.Creation = true;
                return View("Upsert", model);
            }
            var entity = mapper.Map<Session>(model);

            context.Sessions.Add(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var item = context.Sessions.Find(id);
            if (item == null) return NotFound();

            ViewBag.Creation = false;
                LoadHalls();
            LoadFilms();

            var model = mapper.Map<SessionFormModel>(item);

            return View("Upsert", model);
        }

        [HttpPost]
        public IActionResult Edit(SessionFormModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Creation = false;
                LoadFilms();
                LoadHalls();
                return View("Upsert", model);
            }
            var entity = mapper.Map<Session>(model);

            context.Sessions.Update(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var item = context.Sessions.Find(id);

            if (item == null) return NotFound();

            context.Sessions.Remove(item);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Films
        [HttpGet] // by default
        public IActionResult CreateFilm()
        {
            ViewBag.Creation = true;
            LoadGenres();

            return View("UpsertFilm");
        }

        [HttpPost]
        public IActionResult CreateFilm(FilmFormModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadGenres();
                ViewBag.Creation = true;
                return View("UpsertFilm", model);
            }
            var entity = mapper.Map<Film>(model);

            context.Films.Add(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditFilm(int id)
        {
            var item = context.Films.Find(id);
            if (item == null) return NotFound();

            ViewBag.Creation = false;
            LoadGenres();

            var model = mapper.Map<FilmFormModel>(item);

            return View("UpsertFilm", model);
        }

        [HttpPost]
        public IActionResult EditFilm(FilmFormModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Creation = false;
                LoadGenres();
                return View("UpsertFilm", model);
            }
            var entity = mapper.Map<Film>(model);

            context.Films.Update(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteFilm(int id)
        {
            var item = context.Films.Find(id);

            if (item == null) return NotFound();

            context.Films.Remove(item);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion
        private void LoadFilms()
        {
            var Films = new SelectList(context.Films.ToList(), "Id", "Name");
            ViewBag.Films = Films;
        }
        private void LoadGenres()
        {
            var Genres = new SelectList(context.Genres.ToList(), "Id", "Name");
            ViewBag.Genres = Genres;
        }
        private void LoadHalls()
        {
            var Halls = new SelectList(context.Halls.ToList(), "Id", "Name");
            ViewBag.Halls = Halls;
        }
    }
}
