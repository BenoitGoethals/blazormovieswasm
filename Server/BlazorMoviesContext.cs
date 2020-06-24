using blazormovieswasm.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace blazormovieswasm.Server
{
  public class BlazorMoviesContext : DbContext
  {
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<MoviesGenres> MoviesGenres { get; set; }
    public DbSet<MoviesActors> MoviesActors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<MoviesActors>().HasKey(x => new { x.MovieId, x.PersonId });
      modelBuilder.Entity<MoviesGenres>().HasKey(x => new { x.MovieId, x.GenreId });

      base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(
        @"Server=localhost;Database=blazormovieswasm;User Id=blazormoviesuser;Password=88%sr0wr6");
    }
  }
}