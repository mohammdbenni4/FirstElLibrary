using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrdersBrunchesProduct
    {
        [Key]
        public string? Id { get; set; }
        public OrdersBrunches? OrdersBrunches { get; set; }
        public string? OrdersBrunchesId { get; set; }
        public Product? Product { get; set; }
        public string? ProductId { get; set; }
        public int Price { get; set; }
    }
}
