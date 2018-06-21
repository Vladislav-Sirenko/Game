using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class PlatformTypeViewModel
    {
        public PlatformTypeViewModel()
        {
            Games = new List<GameViewModel>();
        }
        public string Type { get; set; }

        public virtual ICollection<GameViewModel> Games { get; set; }
    }
}