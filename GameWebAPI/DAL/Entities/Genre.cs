using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Genre
    {
        public Genre()
        {
            SubGenres = new List<Genre>();
        }
        public string GenreName { get; set; }

        public string ParrentGenreName { get; set; }
        public virtual Genre ParrentGenre { get; set; }
        public virtual ICollection<Genre> SubGenres { get; set; }

    }
}
