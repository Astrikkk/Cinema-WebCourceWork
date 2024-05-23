using CinemaDataBase.Data;
using CinemaDataBase.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly CinemaDBContext context;

        public FilmController(CinemaDBContext context)
        {
            this.context = context;
        }


        #region Films


        [HttpGet("films")]
        public IActionResult GetFilms()
        {
            return Ok(context.Films.ToList());
        }

        [HttpPost("films")]
        public IActionResult CreateFilms(Film model)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Films.Add(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut("films")]
        public IActionResult EditFilms(Film model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var entity = context.Films.AsNoTracking().FirstOrDefault(x => x.Id == model.Id);
            if (entity == null) return NotFound();

            context.Films.Update(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete("films/{id}")]
        public IActionResult DeleteFilms(int id)
        {
            var entity = context.Films.Find(id);
            if (entity == null) return NotFound();

            context.Films.Remove(entity);
            context.SaveChanges();

            return Ok();
        }


        #endregion

        #region Seanses


        [HttpGet("seanses")]
        public IActionResult GetSeanses()
        {
            return Ok(context.Seanses.ToList());
        }



        [HttpPost("seanses")]
        public IActionResult CreateSeanses(Seans model)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Seanses.Add(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut("seanses")]
        public IActionResult EditSeanses(Seans model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var entity = context.Seanses.AsNoTracking().FirstOrDefault(x => x.Id == model.Id);
            if (entity == null) return NotFound();

            context.Seanses.Update(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete("seanses/{id}")]
        public IActionResult DeleteSeanses(int id)
        {
            var entity = context.Seanses.Find(id);
            if (entity == null) return NotFound();

            context.Seanses.Remove(entity);
            context.SaveChanges();

            return Ok();
        }

        #endregion
    }
}
