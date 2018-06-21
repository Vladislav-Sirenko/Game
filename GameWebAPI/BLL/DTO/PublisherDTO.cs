using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class PublisherDTO
    {

        public PublisherDTO()
        {
            Games = new List<GameDTO>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<GameDTO> Games { get; set; }
    }
}
