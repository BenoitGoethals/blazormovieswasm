using System;
using System.Threading.Tasks;
using blazormovieswasm.Client.Helpers;
using blazormovieswasm.Shared.Entities;
using blazormovieswasm.Shared.Dtos;

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

    public async Task<MovieDetailsDto> GetMovieDetailsDto(int id) => await Get<MovieDetailsDto>($"{url}/{id}");

    public async Task<T> Get<T>(string url)
    {
      var response = await httpService.Get<T>(url);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
      return response.Response;
    }

    public async Task<IndexPageDto> GetIndexPageDto()
    {
      var response = await httpService.Get<IndexPageDto>(url);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
      return response.Response;
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