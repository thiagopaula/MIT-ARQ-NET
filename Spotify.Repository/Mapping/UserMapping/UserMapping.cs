using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotify.Domain.User;

namespace Spotify.Repository.Mapping.UserMapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> build)
        {
            build.ToTable("Users");
            build.HasKey(x => x.Id);
            build.Property(x => x.Id).ValueGeneratedOnAdd();
            build.Property(x => x.Name).IsRequired().HasMaxLength(200);
            build.Property(x => x.Photo).IsRequired().HasMaxLength(500);
            build.Property(x => x.DateOfBirth).IsRequired();

            build.OwnsOne(p => p.Email, f =>
            {
                f.Property(x => x.Value).HasColumnName("Email");
            });

            build.OwnsOne(p => p.Password, f =>
            {
                f.Property(x => x.Value).HasColumnName("Password");
            });
        }
    }
}
