using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIDM_3312_Final_Project.Pages;

public class PlayerModel : PageModel
{
    private readonly PlayerContext _context;
    private readonly ILogger<PlayerModel> _logger;
    public List<Player> Players {get; set;} = default!;
    public SelectList PlayerDropDown {get; set;} = default!;

    [BindProperty]
    public Player Player {get; set;} = default!;

    public PlayerModel(PlayerContext context, ILogger<PlayerModel> logger)
    {
        _context = context; 
        _logger = logger;
    }

    public void OnGet()
    {
        Players = _context.Players.ToList();
        PlayerDropDown = new SelectList(Players, "PlayerID", "firstName", "lastName");
    }

    public void OnPost()
    {
        Player = _context.Players.Find(Player.playerID)!;
        Players = _context.Players.ToList();
        PlayerDropDown = new SelectList(Players, "PlayerID", "firstName", "lastName");
    }
}