using System;
using System.ComponentModel.DataAnnotations;



namespace Lab23.Models
{
    public class MovieSearchViewModel
    {
        public MovieSearchViewModel()
        {
        }

        public MovieSearchViewModel(string title, MovieGenre genre)
        {
            Title = title;
            Genre = genre;
        }

        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
    }
}
