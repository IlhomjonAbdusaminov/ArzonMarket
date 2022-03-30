using ArzonMarket.Domain.Entities.Clients;
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
        Task<Client> CreateAsync(Client entity);

        Task<bool> DeleteAsync(Expression<Func<Client, bool>> predicate);

        Task<Client> UpdateAsync(Client entity);

        Task<IQueryable<Client>> GetAllAsync(Expression<Func<Client, bool>> predicate = null);

        Task<Client> GetAsync(Expression<Func<Client, bool>> predicate);
    }
}
