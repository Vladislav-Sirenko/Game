using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class PlatformTypeDTO
    {
        public PlatformTypeDTO()
        {
            Games = new List<GameDTO>();
        }
        public string Type { get; set; }

        public virtual ICollection<GameDTO> Games { get; set; }
    }
}
