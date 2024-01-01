using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductAddOne
    {
        public string? Id { get; set; }
        public string? Name { get; set; }

        public int Price { get; set; }
        public Product? Product { get; set; }
        public string? ProductId { get; set; }
    }
}
