namespace CIDM_3312_Final_Project.Pages
{
    public class Game
    {
        public string? gameID { get; set; }=default!;
        public string? gameDate { get; set; }=default!;
        public List<Player>? gamePlayers { get; set; }=default!;
        public int Score { get; set; }=default!;
        public string? winOrLoss {get; set;}=default!;
    }
}