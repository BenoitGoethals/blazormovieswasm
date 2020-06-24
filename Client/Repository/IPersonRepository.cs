using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public interface IPersonRepository
  {
    Task CreatePerson(Person person);
  }
}