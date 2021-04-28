

using System.ComponentModel.DataAnnotations;

namespace Lab23.Data.Model
{
    public class Movie
    {
            [Key]
            public int Id { get; set; }

            [StringLength(50)]
            public string Title { get; set; }

            [StringLength(20)]
            public string Genre { get; set; }

            
            public double Runtime { get; set; }
        
    }
}
