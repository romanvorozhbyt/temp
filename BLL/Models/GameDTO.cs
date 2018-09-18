using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
  public  class GameDTO:EntityDTO
    {

        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public PublisherDTO Publisher { get; set; }

        public ICollection<GenreDTO> Genres { get; set; }

        public ICollection<PlatformTypeDTO> Platforms { get; set; }
    }
}
