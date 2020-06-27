using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public interface IMovieRepository
  {
    Task<int> CreateMovie(Movie movie);
  }
}