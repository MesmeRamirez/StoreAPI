using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ModelStoreAPI.Dto;
using ServiceStoreAPI;

namespace StoreAPI.Controllers
{
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductController(IProductService productService, IHostingEnvironment hostingEnvironment)
        {
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET 
        [AllowAnonymous]
        [HttpGet("products/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(
                await _productService.Get(id)
                );
        }

        // GET 
        [AllowAnonymous]
        [HttpPatch("products/{id}")]
        public async Task<IActionResult> PartialUpdate(int id, [FromBody] ProductDtoPartial model)
        {
            await _productService.PartialUpdate(id, model);
            return NoContent();
        }

        // GET 
        [HttpGet("products")]
        public async Task<IActionResult> GetAll([FromQuery] ProductList list)
        {
            return Ok(
                await _productService.GetAll(list)
                );
        }

        // POST
        [HttpPost("products")]
        public async Task<IActionResult> ProductPut([FromBody] ProductCreateDto model)
        {
            await _productService.Create(model);
            return NoContent();
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return Ok(
                await _productService.Remove(id)
            );
        }

        [HttpPut("products/{id}/image")]
        public async Task<IActionResult> ImagePut(
            int id,
            [FromBody]FileDto model
        )
        {
            var fileName = model.UniqueName;
            var filePath = $"{_hostingEnvironment.WebRootPath}\\Uploads\\{fileName}";

            using (var ms = model.ReadAsStream())
            using (var file = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                await ms.CopyToAsync(file);
            }

            await _productService.PartialUpdate(id, new ProductDtoPartial
            {
                UrlImage = fileName
            });

            return NoContent();
        }

    }
}
