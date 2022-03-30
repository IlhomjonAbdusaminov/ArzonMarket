using ArzonMarket.Data.Contexts;
using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Entities.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Repositories
{
    public class WorkerRepository : GenericRepository<Worker>, IWorkerRepository
    {
        public WorkerRepository(ArzonMarketDbContext dbContext) : base (dbContext)
        {

        }
    }
}
