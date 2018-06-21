using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PlatformType
    {
        public PlatformType()
        {
            Games = new List<Game>();
        }
        public string Type { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
