using ArzonMarket.Data.Contexts;
using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ArzonMarketDbContext dbContext) : base(dbContext) { }
    }
}
