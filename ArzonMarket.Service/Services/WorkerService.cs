using ArzonMarket.Domain.Entities.Workers;
using ArzonMarket.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Services
{
    public class WorkerService : IWorkerService
    {
        public Task<Worker> CreateAsync(Worker entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Worker, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Worker>> GetAllAsync(Expression<Func<Worker, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Worker> GetAsync(Expression<Func<Worker, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Worker> UpdateAsync(Worker entity)
        {
            throw new NotImplementedException();
        }
    }
}
