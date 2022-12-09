using Microsoft.EntityFrameworkCore;
namespace CIDM_3312_Final_Project.Pages
{
    public class PlayerContext : DbContext
	{
		public PlayerContext (DbContextOptions<PlayerContext> options)
			: base(options)
		{
		}
		public DbSet<Player> Player {get; set;} = default!;
        public object GameStats { get; set; }
    }
}