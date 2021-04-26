using System;
using Microsoft.EntityFrameworkCore;
using Lab23.Data.Model;

namespace Lab23.Data.Model
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
