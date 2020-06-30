using System.Collections.Generic;
using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public interface IPersonRepository
  {
    Task CreatePerson(Person person);
    
    Task<List<Person>> GetPeople();
    Task<List<Person>> GetPeopleByName(string name);
  }
}