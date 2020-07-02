using System;
using System.Linq;
using System.Threading.Tasks;
using blazormovieswasm.Server.Helpers;
using blazormovieswasm.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly BlazorMoviesContext context;
    private readonly IFileStorageService fileStorageService;
    private string containerName = "movies";

    public MoviesController(BlazorMoviesContext context, IFileStorageService fileStorageService)
    {
      this.context = context;
      this.fileStorageService = fileStorageService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MovieDetailsDto>> Get(int id)
    {
      var movie = await context.Movies.Where(x => x.Id == id)
        .Include(x => x.MoviesGenres).ThenInclude(x => x.Genre)
        .Include(x => x.MoviesActors).ThenInclude(x => x.Person)
        .FirstOrDefaultAsync();

      if (movie == null) { return NotFound(); }

      movie.MoviesActors = movie.MoviesActors.OrderBy(x => x.Order).ToList();

      var model = new MovieDetailsDto();
      model.Movie = movie;
      model.Genres = movie.MoviesGenres.Select(x => x.Genre).ToList();
      model.Actors = movie.MoviesActors.Select(x => 
        new Person
        {
          Name = x.Person.Name,
          Picture = x.Person.Picture,
          Character = x.Person.Picture,
          Id = x.PersonId
        
        }).ToList();

      return model;
    }

    [HttpGet]
    public async Task<ActionResult<IndexPageDto>> Get()
    {
      var limit = 6;

      var moviesInTheaters = await context.Movies
        .Where(x => x.InTheaters).Take(limit)
        .OrderByDescending(x => x.ReleaseDate)
        .ToListAsync();

      var todaysDate = DateTime.Today;

      var upcomingReleases = await context.Movies
        .Where(x => x.ReleaseDate > todaysDate)
        .OrderBy(x => x.ReleaseDate).Take(limit)
        .ToListAsync();

      var response = new IndexPageDto();
      response.InTheaters = moviesInTheaters;
      response.UpComingReleases = upcomingReleases;

      return response;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post(Movie movie)
    {

      if (!string.IsNullOrEmpty(movie.Poster))
      {
        var moviePoster = Convert.FromBase64String(movie.Poster);
        movie.Poster = await fileStorageService.SaveFile(moviePoster, "jpg", "movies");
      }

      if (movie.MoviesActors != null)
      {
        for (int i = 0; i < movie.MoviesActors.Count; i++)
        {
          movie.MoviesActors[i].Order = i + 1;
        }
      }
      context.Add(movie);
      await context.SaveChangesAsync();
      return movie.Id;
    }
  }
}