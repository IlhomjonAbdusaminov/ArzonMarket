using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Configurations;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Interfaces
{
    public interface IClientService
    {
        Task<BaseResponse<Client>> CreateAsync(ClientForCreationDto clientDto);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Client, bool>> predicate);

        Task<BaseResponse<Client>> UpdateAsync(ClientForCreationDto clientDto);

        Task<BaseResponse<IQueryable<Client>>> GetAllAsync(PaginationParams @params, Expression<Func<Client, bool>> predicate = null);

        Task<BaseResponse<Client>> GetAsync(Expression<Func<Client, bool>> predicate);
    }
}
