using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class GenreViewModel
    {
        public GenreViewModel()
        {
            SubGenres = new List<GenreViewModel>();
        }
        public string GenreName { get; set; }

        public string ParrentGenreName { get; set; }
        public virtual GenreViewModel ParrentGenre { get; set; }
        public virtual ICollection<GenreViewModel> SubGenres { get; set; }
    }
}