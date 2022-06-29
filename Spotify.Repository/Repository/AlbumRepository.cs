using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using Spotify.Infrastructure.Database;
using Spotify.Repository.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Album>> GetAllAlbum()
        {
            return await Task.FromResult(this._set.Include(x => x.Musics).AsEnumerable());
        }

    }
}
