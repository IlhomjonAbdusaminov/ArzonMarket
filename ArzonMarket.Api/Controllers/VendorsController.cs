using ArzonMarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArzonMarket.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class VendorsController
    {
        private readonly IVendorService vendorService;

        public VendorsController(IVendorService vendorService)
        {
            this.vendorService = vendorService;
        }
    }
}
