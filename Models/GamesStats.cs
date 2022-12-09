using System;
using System.Collections.Generic;

namespace CIDM_3312_Final_Project.Pages
{
    public class GameStats
    {
        public int gameID {get; set; }=default!;
        public int playerID {get; set;}=default!;
        public int goals {get; set;}=default!;
        public int assists {get; set;}=default!;
        public int blocks {get; set;}=default!;
        public int saves {get; set;}=default!;
        public int takeaways {get; set;}=default!;
        public int timePlayed {get; set;}=default!;

    }
}