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
        Task<Vendor> CreateAsync(Vendor entity);

        Task<bool> DeleteAsync(Expression<Func<Vendor, bool>> predicate);

        Task<Vendor> UpdateAsync(Vendor entity);

        Task<IQueryable<Vendor>> GetAllAsync(Expression<Func<Vendor, bool>> predicate = null);

        Task<Vendor> GetAsync(Expression<Func<Vendor, bool>> predicate);
    }
}
