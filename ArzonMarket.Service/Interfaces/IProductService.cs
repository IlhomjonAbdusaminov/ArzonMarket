using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Interfaces
{
    public interface IProductService
    {
        Task<BaseResponse<Product>> CreateAsync(Product entity);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Product, bool>> predicate);

        Task<BaseResponse<Product>> UpdateAsync(Product entity);

        Task<BaseResponse<IQueryable<Product>>> GetAllAsync(Expression<Func<Product, bool>> predicate = null);

        Task<BaseResponse<Product>> GetAsync(Expression<Func<Product, bool>> predicate);
    }
}
