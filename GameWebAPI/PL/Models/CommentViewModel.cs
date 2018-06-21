using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class CommentViewModel
    {
        public CommentViewModel()
        {
            Answers = new List<CommentViewModel>();
        }
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public int? ParrentCommentId { get; set; }
        public virtual CommentViewModel ParrentComment { get; set; }
        public virtual ICollection<CommentViewModel> Answers { get; set; }
        public int GameId { get; set; }
        public GameViewModel Game { get; set; }
    }
}