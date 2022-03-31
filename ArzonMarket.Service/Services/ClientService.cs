using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Configurations;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Domain.Enums;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using ArzonMarket.Service.Extensions;
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

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Client, bool>> predicate)
        {
            BaseResponse<bool> response = new BaseResponse<bool>();

            var existClient = await unitOfWork.Clients.GetAsync(predicate);

            if(existClient is null)
            {
                response.Error = new ErrorResponse(404, "User not found");
                return response;
            }

            existClient.Delete();

            var result = await unitOfWork.Clients.UpdateAsync(existClient);

            await unitOfWork.SaveChangesAsync();

            response.Data = true;

            return response;
        }

        public async Task<BaseResponse<IQueryable<Client>>> GetAllAsync(PaginationParams @params, Expression<Func<Client, bool>> predicate = null)
        {
            var response = new BaseResponse<IQueryable<Client>>();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            var clients = await unitOfWork.Clients.GetAllAsync(predicate);

            response.Data = clients.ToPagedList(@params);

            return response;
        }

        public async Task<BaseResponse<Client>> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            var response = new BaseResponse<Client>();

            var client = await unitOfWork.Clients.GetAsync(predicate);

            if(client is null)
            {
                response.Error = new ErrorResponse(404, "Not Found");
                return response;
            }

            response.Data = client;

            return response;
        }

        public async Task<BaseResponse<Client>> UpdateAsync(string login, string password, ClientForCreationDto clientDto)
        {
            var response = new BaseResponse<Client>();

            var client = await unitOfWork.Clients.GetAsync(p => p.Login == login && p.Password == password && p.State != ItemState.Deleted);

            if(client is null)
            {
                response.Error = new ErrorResponse(404, "Client not found");
                return response;
            }
            
            client.FirstName = clientDto.FirstName;
            client.LastName = clientDto.LastName;
            client.PhoneNumber = clientDto.PhoneNumber;
            client.Login = clientDto.Login;
            client.Password = clientDto.Password;
            client.Update();

            var result = await unitOfWork.Clients.UpdateAsync(client);

            await unitOfWork.SaveChangesAsync();

            response.Data = result;

            return response;
        }
    }
}
