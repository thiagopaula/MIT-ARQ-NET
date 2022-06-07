using Spotify.Domain.Album.ValueObject;

namespace Spotify.Domain.Album
{
    public class Music
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Duration Duration { get; set; }

    }
}
