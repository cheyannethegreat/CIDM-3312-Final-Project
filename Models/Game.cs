using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CIDM_3312_Final_Project
{
    public class Game
    {
        public string? gameID { get; set; }
        public string? gameDate { get; set; }
        public List<Player>? gamePlayers { get; set; }
        public int Score { get; set; }
        public string? winOrLoss {get; set;}
    }
}