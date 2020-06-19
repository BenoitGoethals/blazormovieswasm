using System.Collections.Generic;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Helpers
{
  public interface IRepository
  {
    List<Movie> GetMovies();
  }
}