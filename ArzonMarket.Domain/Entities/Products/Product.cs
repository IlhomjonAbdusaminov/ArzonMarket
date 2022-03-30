using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Domain.Entities.Products
{
    public class Product : IAuditable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }



        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
        public Guid? UpdatedBy { get; set; }
        
        public ItemState State { get; set; }
    }
}
