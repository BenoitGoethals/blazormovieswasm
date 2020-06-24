using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public interface IGenreRepository
  {
    Task CreateGenre(Genre genre);
  }
}