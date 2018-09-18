using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
   public class PublisherDTO :EntityDTO
    {

        public string Key { get; set; }
        public string Name { get; set; }

        public ICollection<GameDTO> Games { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}
