using System;
using System.Collections.Generic;

namespace CIDM_3312_Final_Project.Models
{
    
    public class Player
    {
        public int playerID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int number {get; set;}
        public string? position { get; set; }
        public List<GameStats> GameStats {get; set;}
    }
}
