using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotify.Domain.Album;

namespace Spotify.Repository.Mapping.AlbumMapping
{
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> build)
        {
            build.ToTable("Albums");
            build.HasKey(x => x.Id);
            build.Property(x => x.Id).ValueGeneratedOnAdd();
            build.Property(x => x.Name).IsRequired().HasMaxLength(150);
            build.Property(x => x.Description).IsRequired().HasMaxLength(500);
            build.Property(x => x.Backdrop).HasMaxLength(1024);

            build.OwnsOne(p => p.Band, f =>
            {
                f.Property(x => x.Name).HasColumnName("BandName");
            });

            build.HasMany(x => x.Musics).WithOne().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
