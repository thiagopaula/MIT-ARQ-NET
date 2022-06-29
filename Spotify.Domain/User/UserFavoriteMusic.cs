

using Spotify.Domain.Album;

namespace Spotify.Domain.User
{
    public class UserFavoriteMusic
    {
        public Guid Id { get; set; }

        public virtual Music Music { get; set; }

        public virtual User User { get; set; }
    }
}
