using System;
using System.Threading.Tasks;
using blazormovieswasm.Client.Helpers;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public class MovieRepository : IMovieRepository
  {
    private readonly IHttpService httpService;
    private string url = "api/movies";

    public MovieRepository(IHttpService httpService)
    {
      this.httpService = httpService;
    }

    public async Task<int> CreateMovie(Movie movie)
    {
      var response = await httpService.Post<Movie, int>(url, movie);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
      return response.Response;
    }
  }
}