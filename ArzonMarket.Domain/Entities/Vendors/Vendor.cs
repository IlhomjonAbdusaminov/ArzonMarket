using ArzonMarket.Domain.Commons;
using ArzonMarket.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Domain.Entities.Vendors
{
    public class Vendor : IAuditable
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        
        public DateTime BirthDate { get; set; }

        [MaxLength(30)]
        public string Login { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }

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
