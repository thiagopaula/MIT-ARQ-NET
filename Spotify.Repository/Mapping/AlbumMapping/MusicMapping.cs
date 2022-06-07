

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotify.Domain.Album;

namespace Spotify.Repository.Mapping.AlbumMapping
{
    public class MusicMapping : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> build)
        {
            build.ToTable("Musics");
            build.HasKey(x => x.Id);
            build.Property(x => x.Id).ValueGeneratedOnAdd();
            build.Property(x => x.Name).IsRequired().HasMaxLength(150);

            build.OwnsOne(p => p.Duration, f =>
            {
                f.Property(x => x.Value).HasColumnName("Duracao");
            });
            
        }
    }
}
