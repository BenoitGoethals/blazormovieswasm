using System.Collections.Generic;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Shared.Dtos
{
  public class MovieDetailsDto
  {
    public Movie Movie { get; set; }
    public List<Genre> Genres { get; set; }
    public List<Person> Actors { get; set; }
  }
}