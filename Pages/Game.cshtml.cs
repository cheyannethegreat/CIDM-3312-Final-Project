using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_Final_Project.Pages;
    public class GameModel : PageModel
    {
        private readonly PlayerContext _context;

        public GameModel(PlayerContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

    public IActionResult OnGet(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        if (Game == null)
        {
            return NotFound();
        }
        return Page();
    }
}