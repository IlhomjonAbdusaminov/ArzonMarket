using ArzonMarket.Domain.Entities.Vendors;
using ArzonMarket.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Services
{
    public class VendorService : IVendorService
    {
        public Task<Vendor> CreateAsync(Vendor entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Vendor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vendor>> GetAllAsync(Expression<Func<Vendor, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> GetAsync(Expression<Func<Vendor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> UpdateAsync(Vendor entity)
        {
            throw new NotImplementedException();
        }
    }
}
