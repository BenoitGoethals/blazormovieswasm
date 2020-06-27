using System;
using System.Threading.Tasks;
using blazormovieswasm.Server.Helpers;
using blazormovieswasm.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

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

    [HttpPost]
    public async Task<ActionResult<int>> Post(Movie movie)
    {

      if (!string.IsNullOrEmpty(movie.Poster))
      {
        var moviePoster = Convert.FromBase64String(movie.Poster);
        movie.Poster = await fileStorageService.SaveFile(moviePoster, "jpg", "movies");
      }
      context.Add(movie);
      await context.SaveChangesAsync();
      return movie.Id;
    }
  }
}