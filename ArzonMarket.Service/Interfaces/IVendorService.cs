using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Interfaces
{
    public interface IVendorService
    {
        Task<BaseResponse<Vendor>> CreateAsync(Vendor entity);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Vendor, bool>> predicate);

        Task<BaseResponse<Vendor>> UpdateAsync(Vendor entity);

        Task<BaseResponse<IQueryable<Vendor>>> GetAllAsync(Expression<Func<Vendor, bool>> predicate = null);

        Task<BaseResponse<Vendor>> GetAsync(Expression<Func<Vendor, bool>> predicate);
    }
}
