using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CommentDTO :EntityDTO
    {
        public string Name { get; set; }
        public string Body { get; set; }

        public GameDTO Game { get; set; }

        public CommentDTO Parent { get; set; }
    }
}
