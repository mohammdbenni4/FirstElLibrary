using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Customer
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }

        public City? City { get; set; }
        public string? CityId { get; set; }

        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? Neighborhood { get; set; }
        
        public DateOnly? BornDate { get; set; }

        public Address? Address { get; set; }
        public string? AddressId { get; set; }

    }
    
}
