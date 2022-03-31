using ArzonMarket.Data.Contexts;
using ArzonMarket.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArzonMarketDbContext dbContext;

        public UnitOfWork(ArzonMarketDbContext dbContext)
        {
            this.dbContext = dbContext;

            Clients = new ClientRepository(dbContext);
            Products = new ProductRepository(dbContext);
            Vendors = new VendorRepository(dbContext);
            Workers = new WorkerRepository(dbContext);
        }

        public IClientRepository Clients { get; private set; }

        public IProductRepository Products { get; private set; }

        public IVendorRepository Vendors { get; private set; }

        public IWorkerRepository Workers { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
