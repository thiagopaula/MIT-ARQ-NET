using Spotify.Infrastructure.Database;

namespace Spotify.Domain.User.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByPassword(string username, string password);
    }
}
