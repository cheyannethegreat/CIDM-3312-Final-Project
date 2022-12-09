using System;
using System.Collections.Generic;

namespace CIDM_3312_Final_Project.Pages
{
    
    public class Player
    {
        public int playerID { get; set; } =default!;
        public string? firstName { get; set; } =default!;
        public string? lastName { get; set; }=default!;
        public int number {get; set;}=default!;
        public string? position { get; set; }=default!;
        public List<GameStats>? GameStats {get; set;}=default!;
    }
}
