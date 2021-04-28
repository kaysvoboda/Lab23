using System;
using Microsoft.EntityFrameworkCore;
using Lab23.Data.Model;
using System.Collections.Generic;

namespace Lab23.Data
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        internal IEnumerable<object> Get()
        {
            throw new NotImplementedException();
        }
    }
}
