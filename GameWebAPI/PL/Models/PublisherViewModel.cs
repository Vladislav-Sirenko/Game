using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class PublisherViewModel
    {

        public PublisherViewModel()
        {
            Games = new List<GameViewModel>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<GameViewModel> Games { get; set; }
    }
}