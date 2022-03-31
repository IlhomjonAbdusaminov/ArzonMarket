using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Enums;
using ArzonMarket.Domain.Enums.Products;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArzonMarket.Domain.Entities.Products
{
    public class Product : IAuditable
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        /// <summary>
        /// Product unit (kgs, pcs)
        /// </summary>
        public ProductUnit Unit { get; set; } 

        /// <summary>
        /// Product type (fruit, drinks...) 
        /// </summary>
        public ProductType Type { get; set; }

        public float Residue { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
        public Guid? UpdatedBy { get; set; }

        public ItemState State { get; set; } = ItemState.Created;
    }
}
