using System;
using System.Collections.Generic;
using Lab23.Models;
using Lab23.Data;
using System.Threading.Tasks;
using Lab23.Data.Model;

namespace Lab23.Repositories
{
    public interface IMovieRepository
    {
        
        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<Movie>> Get();
        Task<Movie> Get(int id);
        Task<List<Movie>> Search(string title);
        Task Update(Movie movie);
        Task Register(Movie movie);
        Task<List<Movie>> GenreSearch(string genre);



    }
}
