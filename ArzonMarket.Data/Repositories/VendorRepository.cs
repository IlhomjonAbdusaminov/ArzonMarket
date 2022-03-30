using ArzonMarket.Data.Contexts;
using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Repositories
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        public VendorRepository(ArzonMarketDbContext dbContext) : base(dbContext)
        {

        }
    }
}
