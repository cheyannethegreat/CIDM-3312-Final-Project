using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIDM_3312_Final_Project.Pages;
    public class AddGameStats : PageModel
    {
        private readonly ILogger<AddGameStats> _logger;
        private readonly PlayerContext _context; // Player Database context
        [BindProperty]
        public GameStats GameStats {get; set;}
        public SelectList PlayersDropDown {get; set;}

        public AddGameStats(PlayerContext context, ILogger<AddGameStats> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            PlayersDropDown = new SelectList(_context.Players.ToList(), "playerID", "firstName");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }

    private class context
    {
        public static object? GameStats { get; internal set; }

        internal static void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}