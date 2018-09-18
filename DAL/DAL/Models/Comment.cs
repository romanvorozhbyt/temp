using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace DAL.Models
{
   public class Comment:Entity
    {
        
        public string Name { get; set; }
        public string Body { get; set; }

        public Game Game {get;set;}

        public Comment Parent { get; set; }
    }
}
