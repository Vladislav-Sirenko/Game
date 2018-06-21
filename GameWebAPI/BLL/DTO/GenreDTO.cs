using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class GenreDTO
    {
        public GenreDTO()
        {
            SubGenres = new List<GenreDTO>();
        }
        public string GenreName { get; set; }

        public string ParrentGenreName { get; set; }
        public virtual GenreDTO ParrentGenre { get; set; }
        public virtual ICollection<GenreDTO> SubGenres { get; set; }
    }
}
