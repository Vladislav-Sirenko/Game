using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Entities
{
    public class Game
    {
        public Game()
        {
            PlatformTypes = new List<PlatformType>();
            Comments = new List<Comment>();
        }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<PlatformType> PlatformTypes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
