using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Comment
    {
        public Comment()
        {
            Answers = new List<Comment>();
        }
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public int? ParrentCommentId { get; set; }
        public virtual Comment ParrentComment { get; set; }
        public virtual ICollection<Comment> Answers { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}
