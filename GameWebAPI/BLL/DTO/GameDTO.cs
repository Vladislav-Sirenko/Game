using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
  public  class GameDTO
    {
        public GameDTO()
        {
            PlatformTypes = new List<PlatformTypeDTO>();
            Comments = new List<CommentDTO>();
        }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PublisherId { get; set; }
        public virtual PublisherDTO Publisher { get; set; }
        public virtual ICollection<PlatformTypeDTO> PlatformTypes { get; set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
