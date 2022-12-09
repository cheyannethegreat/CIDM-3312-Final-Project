using CIDM_3312_Final_Project.Pages;

namespace CIDM_3312_Final_Project
{
    internal class Models
    {
        internal class PlayerContext
        {
            internal readonly object? Player;

            internal object Attach(Player player)
            {
                throw new NotImplementedException();
            }

            internal Task SaveChangesAsync()
            {
                throw new NotImplementedException();
            }

            public static implicit operator PlayerContext(Pages.PlayerContext v)
            {
                throw new NotImplementedException();
            }
        }
    }
}