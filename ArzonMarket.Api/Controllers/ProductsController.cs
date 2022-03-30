using ArzonMarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArzonMarket.Api.Controllers
{
    [ApiController]
    [Route("Api/[conroller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
    }
}
