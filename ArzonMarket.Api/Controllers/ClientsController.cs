using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using ArzonMarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArzonMarket.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientsController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponse<Client>>> Create(ClientForCreationDto clientDto)
        {
            var result = await clientService.CreateAsync(clientDto);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }
    }
}
