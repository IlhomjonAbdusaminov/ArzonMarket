using ArzonMarket.Domain.Entities.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Interfaces
{
    public interface IWorkerService
    {
        Task<Worker> CreateAsync(Worker entity);

        Task<bool> DeleteAsync(Expression<Func<Worker, bool>> predicate);

        Task<Worker> UpdateAsync(Worker entity);

        Task<IQueryable<Worker>> GetAllAsync(Expression<Func<Worker, bool>> predicate = null);

        Task<Worker> GetAsync(Expression<Func<Worker, bool>> predicate);
    }
}
