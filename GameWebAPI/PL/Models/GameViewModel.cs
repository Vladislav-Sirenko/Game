using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class GameViewModel
    {
        public GameViewModel()
        {
            PlatformTypes = new List<PlatformTypeViewModel>();
            Comments = new List<CommentViewModel>();
        }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PublisherId { get; set; }
        public virtual PublisherViewModel Publisher { get; set; }
        public virtual ICollection<PlatformTypeViewModel> PlatformTypes { get; set; }
        public virtual ICollection<CommentViewModel> Comments { get; set; }
    }
}