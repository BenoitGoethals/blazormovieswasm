using System.Threading.Tasks;
using blazormovieswasm.Shared.Dtos;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public interface IMovieRepository
  {
    Task<int> CreateMovie(Movie movie);
    Task<T> Get<T>(string url);
    Task<IndexPageDto> GetIndexPageDto();
    Task<MovieDetailsDto> GetMovieDetailsDto(int id);
  }
}