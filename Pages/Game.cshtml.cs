using CIDM_3312_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_Final_Project.Models
{
    public class GameModel : PageModel
    {
        private readonly PlayerContext _context;

        public GameModel(PlayerContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.GameStats.FirstOrDefaultAsync(m => m.Id == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}