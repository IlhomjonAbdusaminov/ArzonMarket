﻿using ArzonMarket.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Data.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product> 
    {
    }
}
