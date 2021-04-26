using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace Lab23.Data
{
    public class Movie
    {

            public int Id { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public double Runtime { get; set; }
        
    }
}
