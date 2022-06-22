using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spotify.Domain.Album.Repository;
using Spotify.Domain.User.Repository;
using Spotify.Repository.Context;
using Spotify.Repository.Repository;

namespace Spotify.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionStrng)
        {
            services.AddDbContext<SpotifyContext>(c =>
            {
                c.UseSqlServer(connectionStrng);
            });

            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
