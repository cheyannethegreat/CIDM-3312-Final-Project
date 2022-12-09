using Microsoft.EntityFrameworkCore;


namespace CIDM_3312_Final_Project.Pages
{
	public class PlayerContext : DbContext
	{
        public PlayerContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
		}
		public DbSet<Player>? Players {get; set;}
		public DbSet<GameStats>? GameStats {get; set;}
	}
}