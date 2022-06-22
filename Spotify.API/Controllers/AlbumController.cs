using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using Spotify.Infrastructure.Database;

namespace Spotify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        public IAlbumRepository _albumRepository { get; }
        public AlbumController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this._albumRepository.GetAll());
        }
    }
}
