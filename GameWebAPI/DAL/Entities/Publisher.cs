using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Publisher
    {
        public Publisher()
        {
            Games = new List<Game>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Game> Games { get; set; }
    }
}
