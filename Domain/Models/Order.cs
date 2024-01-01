using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Order
    {
        [Key]
        public string? Id { get; set; }
        public Customer? Customer { get; set; }
        public string? CustomerId{ get; set; }
        public string? MobileNumber { get; set; }
        public DateTime? Date{ get; set; }

        public Driver? Driver { get; set; }
        public string? DriverId { get; set; }

        public bool PaymentImmedeitly { get; set; }

        public Address? Address { get; set; }
        public string? AddressId { get; set; }

        public OrderStatus? OrderStatus { get; set; }
        public string? OrderStatusId { get; set; }

    }
}
