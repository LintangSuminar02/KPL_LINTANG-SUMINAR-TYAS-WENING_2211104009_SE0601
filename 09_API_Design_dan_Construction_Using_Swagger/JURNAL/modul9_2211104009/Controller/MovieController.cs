using Microsoft.AspNetCore.Mvc;
using modul9_2211104009.Models;
using System.Collections.Generic;

namespace modul9_2211104009.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty..."
            },
            new Movie {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years..."
            },
            new Movie {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman faces the Joker in a battle for Gotham City."
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get() => movies;

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();
            return movies[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Movie newMovie)
        {
            movies.Add(newMovie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();
            movies.RemoveAt(id);
            return Ok();
        }
    }
}
