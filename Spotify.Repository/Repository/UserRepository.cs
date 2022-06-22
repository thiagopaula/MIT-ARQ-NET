using Spotify.Domain.User;
using Spotify.Domain.User.Repository;
using Spotify.Infrastructure.Database;
using Spotify.Repository.Context;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SpotifyContext context) : base(context)
        {

        }

        public async Task<User> GetUserByPassword(string username, string password)
        {
            return await this.FindOneByCriteria(x => x.Email.Value == username
                                                 && x.Password.Value == password);
        }
    }
}
