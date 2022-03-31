using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Configurations;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Domain.Enums;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using ArzonMarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("All")]
        public async Task<ActionResult<BaseResponse<Client>>> Get([FromForm] string login, [FromForm] string password)
        {
            var result = await clientService.GetAsync(p => p.Login == login && p.Password == password);

            return StatusCode(result.Code ?? result.Code.Value, result);
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse<Client>>> GetAll([FromQuery] PaginationParams @params)
        {
            var results = await clientService.GetAllAsync(@params);

            return StatusCode(results.Code ?? results.Code.Value, results);
        }

        [HttpDelete]
        public async Task<ActionResult<BaseResponse<bool>>> Delete(string login, string password)
        {
            var result = await clientService.DeleteAsync(p => p.Login == login && p.Password == password && p.State != ItemState.Deleted);

            return StatusCode(result.Code ?? result.Code.Value, result);
        }
    }
}
