

using Spotify.Domain.Album;

namespace Spotify.Domain.User
{
    public class UserFavoriteMusic
    {
        public Guid Id { get; set; }

        public Music Music { get; set; }

        public User User { get; set; }
    }
}
