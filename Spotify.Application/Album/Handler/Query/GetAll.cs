using MediatR;
using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Handler.Query
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {

    }

    public class GetAllQueryCommandResponse
    {
        public List<AlbumOutputDto> Albums { get; set; }

        public GetAllQueryCommandResponse()
        {

        }

        public GetAllQueryCommandResponse(List<AlbumOutputDto> albuns)
        {
            this.Albums = albuns;
        }
    }
}
