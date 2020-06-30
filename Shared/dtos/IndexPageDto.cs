using System.Collections.Generic;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Shared.Dtos
{
  public class IndexPageDto
  {
    public List<Movie> InTheaters { get; set; }
    public List<Movie> UpComingReleases { get; set; }    
  }
}