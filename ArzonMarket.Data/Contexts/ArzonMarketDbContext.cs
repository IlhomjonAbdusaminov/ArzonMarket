using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Domain.Entities.Vendors;
using ArzonMarket.Domain.Entities.Workers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.Contexts
{
    public class ArzonMarketDbContext : DbContext
    {
        public ArzonMarketDbContext(DbContextOptions<ArzonMarketDbContext> options)
            : base(options) { }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Vendor> Vendors { get; set; }

        public virtual DbSet<Worker> Workers { get; set; }
    }
}
