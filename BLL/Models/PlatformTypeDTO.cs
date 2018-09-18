using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
   public class PlatformTypeDTO :EntityDTO
    {
        public string Name { get; set; }

        public ICollection<GameDTO> Games { get; set; }

    }
}
