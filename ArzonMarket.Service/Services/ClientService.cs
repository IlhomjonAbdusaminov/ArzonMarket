using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Service.Interfaces;
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

        public ClientService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Task<BaseResponse<Client>> CreateAsync(Client entity)
        {
            throw new NotImplementedException();
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
