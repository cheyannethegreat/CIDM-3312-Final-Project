using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIDM_3312_Final_Project.Pages
{
    public class IndexModel : PageModel
    {
        // IndexModel needs access to database, so we make DbContext variable here
        private readonly PlayerContext _context;
        private readonly ILogger<IndexModel> _logger;
        
        public List<Player> Players {get; set;}

        public IndexModel(PlayerContext context, ILogger<IndexModel> logger)
        {
            _context = context; // Read in DbContext here
            _logger = logger;
        }

        public void OnGet()
        {
            
            Players = _context.Players.ToList();
        }
    }
}