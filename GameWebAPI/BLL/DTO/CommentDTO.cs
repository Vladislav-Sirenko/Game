using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CommentDTO
    {
        public CommentDTO()
        {
            Answers = new List<CommentDTO>();
        }
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public int? ParrentCommentId { get; set; }
        public virtual CommentDTO ParrentComment { get; set; }
        public virtual ICollection<CommentDTO> Answers { get; set; }
        public int GameId { get; set; }
        public GameDTO Game { get; set; }
    }
}
