using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelStoreAPI.Dto;
using ServiceStoreAPI;

namespace StoreAPI.Controllers
{
    [Authorize]
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        // POST
        [HttpPost("likes")]
        public async Task<IActionResult> Create([FromBody] LikeCreateDto model)
        {
            return Ok(await _likeService.Create(model));
        }

        [HttpDelete("likes/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return Ok(await _likeService.Remove(id));
        }
    }
}
