using KuzemBackendDotnet.Domain;
using Microsoft.AspNetCore.Mvc;

namespace KuzemBackendDotnet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService )
        {
            this._productService = productService;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }
}
