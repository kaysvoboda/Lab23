using System;
namespace Lab23.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
        public double Runtime { get; set; }
        
    }
}
