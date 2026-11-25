using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>());

        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "Interstellar",
                ReleaseDate = new DateTime(2014, 11, 7),
                Genre = "Science Fiction",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Genre = "Science Fiction",
                Price = 8.99M
            }
        );

        context.SaveChanges();
    }
}