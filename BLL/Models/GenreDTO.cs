using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
   public class GenreDTO:EntityDTO
    {

        public string Name { get; set; }
        public GenreDTO ParentGenre { get; set; }
        public ICollection<GameDTO> Games { get; set; }
    }
}
