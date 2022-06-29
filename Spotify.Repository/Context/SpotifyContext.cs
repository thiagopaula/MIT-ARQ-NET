using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Spotify.Repository.Context
{
    public class SpotifyContext : DbContext
    {
        public SpotifyContext(DbContextOptions<SpotifyContext> options) : base(options)
        {
        }
        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpotifyContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(c => c.AddConsole());

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
