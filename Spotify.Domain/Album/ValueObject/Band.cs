
namespace Spotify.Domain.Album.ValueObject
{
    public class Band
    {
        public Band()
        {

        }
        public Band(String name)
        {
            this.Name = name;
        }

        public String Name { get; set; }

    }
}
