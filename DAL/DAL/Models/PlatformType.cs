using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class PlatformType :Entity
    {
     
        public string Name { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; }

    }
}
