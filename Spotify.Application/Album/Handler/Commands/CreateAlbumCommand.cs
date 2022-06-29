using MediatR;
using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Handler.Commands
{
    public class CreateAlbumCommand: IRequest<CreateAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }

        public CreateAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }

    }
}
