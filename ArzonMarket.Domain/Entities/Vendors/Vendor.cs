using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Domain.Entities.Vendors
{
    public class Vendor : IAuditable
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
        public Guid? UpdatedBy { get; set; }
        
        public ItemState State { get; set; }

        public void Create()
        {
            CreatedAt = DateTime.Now;
            State = ItemState.Deleted;
        }

        public void Update()
        {
            UpdatedAt = DateTime.Now;
            State = ItemState.Updated;
        }

        public void Delete()
        {
            State = ItemState.Deleted;
        }
    }
}
