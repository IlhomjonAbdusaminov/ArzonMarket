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
        Task<Product> CreateAsync(Product entity);

        Task<bool> DeleteAsync(Expression<Func<Product, bool>> predicate);

        Task<Product> UpdateAsync(Product entity);

        Task<IQueryable<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate = null);

        Task<Product> GetAsync(Expression<Func<Product, bool>> predicate);
    }
}
