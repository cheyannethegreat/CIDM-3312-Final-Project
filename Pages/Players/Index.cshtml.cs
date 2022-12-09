using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_Final_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CIDM_3312_Final_Project.Models.PlayerContext _context;

        public IndexModel(CIDM_3312_Final_Project.Models.PlayerContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}