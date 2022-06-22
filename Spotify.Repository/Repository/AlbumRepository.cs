using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using Spotify.Infrastructure.Database;
using Spotify.Repository.Context;

namespace Spotify.Repository.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context) : base(context)
        {
        }


    }
}
