using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using ArzonMarket.Service.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<BaseResponse<Client>> CreateAsync(ClientForCreationDto clientDto)
        {
            BaseResponse<Client> response = new BaseResponse<Client>();

            var existClient = await unitOfWork.Clients.GetAsync(p => p.PhoneNumber == clientDto.PhoneNumber);

            if(existClient != null)
            {
                response.Error = new ErrorResponse(400, "User is exist");
                return response;
            }

            var mapperClient = mapper.Map<Client>(clientDto);

            var result = await unitOfWork.Clients.CreateAsync(mapperClient);

            await unitOfWork.SaveChangesAsync();

            response.Data = result;

            return response;

        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IQueryable<Client>>> GetAllAsync(Expression<Func<Client, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Client>> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Client>> UpdateAsync(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
