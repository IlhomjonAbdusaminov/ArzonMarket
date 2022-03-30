using ArzonMarket.Data.Contexts;
using ArzonMarket.Data.IRepositories;
using ArzonMarket.Domain.Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ArzonMarketDbContext dbContext) : base(dbContext)
        {

        }
    }
}
