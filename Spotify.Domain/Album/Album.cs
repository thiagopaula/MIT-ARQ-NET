
using Spotify.Domain.Album.ValueObject;

namespace Spotify.Domain.Album
{
    public class Album
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Backdrop { get; set; }
        public Band Band { get;set; }
        public IList<Music> Musics {get; set; }
        
    }
}
