using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductCategory
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }

        public Brunch? Brunch { get; set; }
        public string? BrunchId { get; set; }

        public Product? Product { get; set; }
        public string? ProductId { get; set; }

        public string? ImageUrl { get; set; }
    }
}
