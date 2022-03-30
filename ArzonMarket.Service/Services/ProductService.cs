using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Products;
using ArzonMarket.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Services
{
    public class ProductService : IProductService
    {
        public Task<BaseResponse<Product>> CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IQueryable<Product>>> GetAllAsync(Expression<Func<Product, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Product>> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
