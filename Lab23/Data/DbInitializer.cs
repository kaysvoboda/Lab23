using System;
using System.Linq;
using Lab23.Data.Model;


namespace Lab23.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any())
            {
                return;
            }

            context.Movies.AddRange(new[]
            {
                new Movie
                {
                    Title = "The Little Rascals",
                    Runtime = 85,
                    Genre = "Family"
                },
                 new Movie
                {
                    Title = "Monty Python",
                    Runtime = 105,
                    Genre = "Comedy"
                },

                new Movie
                {
                    Title = "The Notebook",
                  Runtime = 95,
                    Genre = "Romance"
                },
            });
            context.SaveChanges();
        }
    }
}
