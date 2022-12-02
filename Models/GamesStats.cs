using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CIDM_3312_Final_Project
{
    public class GameStats
    {
        public int gameID {get; set; }
        public int playerID {get; set;}
        public int goals {get; set;}
        public int assists {get; set;}
        public int blocks {get; set;}
        public int saves {get; set;}
        public int takaways {get; set;}
        public string? timePlayed {get; set;}

    }
}