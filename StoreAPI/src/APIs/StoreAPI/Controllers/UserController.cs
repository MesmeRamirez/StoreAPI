using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelStoreAPI.Dto;
using ServiceStoreAPI;

namespace StoreAPI.Controllers
{
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET 
        [AllowAnonymous]
        [HttpGet("users/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(
                await _userService.Get(id)
                );
        }
    }
}
