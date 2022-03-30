using ArzonMarket.Domain.Commons;
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
        Task<BaseResponse<Worker>> CreateAsync(Worker entity);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Worker, bool>> predicate);

        Task<BaseResponse<Worker>> UpdateAsync(Worker entity);

        Task<BaseResponse<IQueryable<Worker>>> GetAllAsync(Expression<Func<Worker, bool>> predicate = null);

        Task<BaseResponse<Worker>> GetAsync(Expression<Func<Worker, bool>> predicate);
    }
}
