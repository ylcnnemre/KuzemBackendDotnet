using KuzemBackendDotnet.Domain;
using Microsoft.AspNetCore.Mvc;

namespace KuzemBackendDotnet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _configuration;
        public ProductController(IProductService productService,IConfiguration configuration )
        {
            this._productService = productService;
            this._configuration = configuration;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            var connectionString = _configuration["AppName"];
            return Ok(connectionString);
        }
    }
}
