using System;
using System.Collections.Generic;
using Lab23.Models;
using Lab23.Data;
using System.Threading.Tasks;


namespace Lab23.Repositories
{
    public interface IMovieRepository
    {

        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<Movie>> Get();
        Task<Movie> Get(int id);
        Task Update(Movie movie);
        Task Create(Movie movie);
    }
}
