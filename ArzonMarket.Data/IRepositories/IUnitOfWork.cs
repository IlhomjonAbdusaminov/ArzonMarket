using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }

        IProductRepository Products { get; }

        IVendorRepository Vendors { get; }

        IWorkerRepository Workers { get; }

        Task SaveChangesAsync();
    }
}
