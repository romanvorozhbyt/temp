using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Genre : Entity
    {

        public string Name { get; set; }
        public Genre ParentGenre { get; set; }
        public ICollection<GameGenre> GameGenres {get; set;}
    }
}
