using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazormovieswasm.Server.Helpers;
using blazormovieswasm.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blazormovieswasm.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PeopleController : ControllerBase
  {
    private readonly BlazorMoviesContext context;
    private readonly IFileStorageService fileStorageService;

    public PeopleController(BlazorMoviesContext context, IFileStorageService fileStorageService)
    {
      this.context = context;
      this.fileStorageService = fileStorageService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Person>>> Get()
    {
      return await context.People.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post(Person person)
    {

      if (!string.IsNullOrEmpty(person.Picture))
      {
        var personPicture = Convert.FromBase64String(person.Picture);
        person.Picture = await fileStorageService.SaveFile(personPicture, "jpg", "people");
      }
      context.Add(person);
      await context.SaveChangesAsync();
      return person.Id;
    }
  }
}