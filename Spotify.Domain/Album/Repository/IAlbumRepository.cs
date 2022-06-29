using Spotify.Infrastructure.Database;

namespace Spotify.Domain.Album.Repository
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<IEnumerable<Album>> GetAllAlbum();
    }
}
