using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab23.Data;
using Lab23.Models;

namespace Lab23.Repositories
{
    public class MovieDbRepository: IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieDbRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task<List<Movie>> Get()
        {
            return await _context.Movies.ToListAsync();
        }
        public async Task<Movie> Get(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Movie movie)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Movie movie)
        {

            _context.Update(movie);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

        }


        public async Task<bool> Exists(int id)
        {
            return await _context.Movies.AnyAsync(e => e.Id == id);
        }
    }
}
