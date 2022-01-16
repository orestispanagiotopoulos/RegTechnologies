using Microsoft.AspNetCore.Mvc;
using MovieInfo.Api.Services;
using System.Collections.Generic;
using System.Linq;

namespace MovieInfo.Api.Contollers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(MoviesDataStorage.Current.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            // find city
            var movieToReturn = MoviesDataStorage.Current.Movies
                .FirstOrDefault(c => c.Id == id);

            if (movieToReturn == null)
            {
                return NotFound();
            }

            return Ok(movieToReturn);
        }
    }
}
