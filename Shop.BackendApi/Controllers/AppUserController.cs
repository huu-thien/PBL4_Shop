using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_Application.Catalog.Products;

namespace Shop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUser _AppUserService;
        public AppUserController(IAppUser AppUserService)
        {
            _AppUserService = AppUserService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _AppUserService.GetAll();
            return Ok(products);
        }
    }
}
