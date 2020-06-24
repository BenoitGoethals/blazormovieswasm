using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace blazormovieswasm.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class GenresController : ControllerBase
  {
    private readonly BlazorMoviesContext context;

    public GenresController(BlazorMoviesContext context)
    {
      this.context = context;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post (Genre genre)
    {
      context.Add(genre);
      await context.SaveChangesAsync();
      return genre.Id;
    }
  }
}