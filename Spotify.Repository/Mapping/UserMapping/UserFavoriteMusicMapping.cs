using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotify.Domain.User;

namespace Spotify.Repository.Mapping.UserMapping
{
    public class UserFavoriteMusicMapping : IEntityTypeConfiguration<UserFavoriteMusic>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteMusic> build)
        {
            build.ToTable("UserFavoriteMusics");
            build.HasKey(x => x.Id);
            build.Property(x => x.Id).ValueGeneratedOnAdd();

            build.HasOne(p => p.Music).WithMany();
            build.HasOne(x => x.User).WithMany(x => x.FavoriteMusics);
        }
    }
}
