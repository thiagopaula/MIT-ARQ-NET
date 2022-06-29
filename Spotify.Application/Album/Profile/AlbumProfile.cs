using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile()
        {
            CreateMap<Domain.Album.Music, MusicOutputDto>()
                .ForMember(x => x.Duration, f => f.MapFrom(m => m.Duration.FormatValue));

            CreateMap<MusicInputDto, Domain.Album.Music>()
                .ForPath(x => x.Duration.Value, f => f.MapFrom(m => m.Duration));

            CreateMap<Domain.Album.Album, AlbumOutputDto>()
                .ForMember(x => x.Band, f => f.MapFrom(m => m.Band.Name));

            CreateMap<AlbumInputDto, Domain.Album.Album>()
                .ForPath(x => x.Band.Name, f => f.MapFrom(m => m.Band));

        }
    }
}
