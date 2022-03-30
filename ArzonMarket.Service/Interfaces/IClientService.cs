using ArzonMarket.Domain.Commons;
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

        Task<BaseResponse<Client>> UpdateAsync(Client entity);

        Task<BaseResponse<IQueryable<Client>>> GetAllAsync(Expression<Func<Client, bool>> predicate = null);

        Task<BaseResponse<Client>> GetAsync(Expression<Func<Client, bool>> predicate);
    }
}
