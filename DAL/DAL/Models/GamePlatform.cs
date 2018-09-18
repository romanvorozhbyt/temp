using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class GamePlatform
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int PlatformId { get; set; }
        public PlatformType Platform { get; set; }
    }
}
