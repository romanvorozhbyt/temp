using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
   public class Publisher : Entity
    {
       

        public string Key { get; set; }
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }

    }
}
