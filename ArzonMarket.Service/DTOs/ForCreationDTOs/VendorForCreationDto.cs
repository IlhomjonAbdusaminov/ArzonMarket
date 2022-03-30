using System;
using System.ComponentModel.DataAnnotations;

namespace ArzonMarket.Service.DTOs.ForCreationDTOs
{
    public class VendorForCreationDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required ]
        public DateTime BirthDate { get; set; }
    }
}
