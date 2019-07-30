using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelStoreAPI.Dto;
using ServiceStoreAPI;

namespace StoreAPI.Controllers
{
    [Authorize]
    public class BuyController : Controller
    {
        private readonly IBuyService _buyService;

        public BuyController(IBuyService buyService)
        {
            _buyService = buyService;
        }

        // POST
        [HttpPost("userProducts")]
        public async Task<IActionResult> Create([FromBody] UserPerProductCreateDto model)
        {
            return Ok(await _buyService.Create(model));
        }
    }
}
