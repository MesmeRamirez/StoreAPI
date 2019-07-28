using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelStoreAPI.Dto;
using ServiceStoreAPI;

namespace StoreAPI.Controllers
{
    [Authorize]
    public class LogPriceController : Controller
    {
        private readonly ILogPriceService _logPriceService;

        public LogPriceController(ILogPriceService logPriceService)
        {
            _logPriceService = logPriceService;
        }

        // POST
        [HttpPost("logprices")]
        public async Task<IActionResult> Create([FromBody] LogPriceProductCreateDto model)
        {
            await _logPriceService.Create(model);
            return NoContent();
        }
    }
}
